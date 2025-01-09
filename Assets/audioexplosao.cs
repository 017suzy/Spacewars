using UnityEngine;

public class audioexplosao : MonoBehaviour
{   public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.volume = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
