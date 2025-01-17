using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotonextscene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(NextScene());
        Destroy(GameObject.Find("Scene Manager"));
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("Scene Manager"));
    }

    IEnumerator NextScene() 
    {
        if (SceneManager.GetSceneByName("Cutscene").isLoaded)
        {
            yield return new WaitForSeconds(6f);
            SceneManager.LoadScene("singleplayer");
        }
        else if (SceneManager.GetSceneByName("Cutscene2").isLoaded)
        {
            yield return new WaitForSeconds(6f);
            SceneManager.LoadScene("multiplayer");
        }
    }
}