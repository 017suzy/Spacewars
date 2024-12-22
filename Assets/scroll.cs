using UnityEngine;
using TMPro;
using System.Collections;

public class scroll : MonoBehaviour
{
    float scrollSpeed = 50f;
    float textbeginning = -281f;
    float textending = 800f;
    
    RectTransform rectTransf;
    [SerializeField]
    TextMeshProUGUI MainText;

    [SerializeField]
    bool isLooping = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rectTransf = GetComponent<RectTransform>();
        StartCoroutine(AutoScroll());
    }

    IEnumerator AutoScroll()
    {
        while (rectTransf.localPosition.y < textending)
        {
            rectTransf.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
            if (rectTransf.localPosition.y > textending)
            {
                if (isLooping)
                {
                    rectTransf.localPosition = Vector3.up * textbeginning;
                }
                else
                {
                    break;
                }
            }
            yield return null;
        }
    }
}