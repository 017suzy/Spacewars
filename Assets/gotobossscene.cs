using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotobossscene : MonoBehaviour
{

   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(NextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NextScene() 
    {
        yield return new WaitForSeconds(45f);
        SceneManager.LoadScene("BOSSFIGHT");
    }
}
