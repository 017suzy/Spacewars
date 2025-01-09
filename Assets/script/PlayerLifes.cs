
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerLifes : MonoBehaviour
{       

    
    public int lives = 3;
    public Image[] livesUI;
    public FloatValue currentHealth;
    public Signal playerHealthSignal;   
    public AudioSource audioSource; // Fonte de áudio
    public AudioClip damageSound; // Som de dano
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake(){
        
       

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "balaInimigo")
        {  
            
            currentHealth.RuntimeValue--;
            playerHealthSignal.Raise();
            if (audioSource != null && damageSound != null)
            {
                audioSource.PlayOneShot(damageSound);
            }
            Destroy(collision.gameObject);          
            if(currentHealth.RuntimeValue < 0){
                Debug.Log("You're Dead");                
                Destroy(gameObject);
                SceneManager.LoadScene("gameover");
                
            }
          
        }
        
    }
}
