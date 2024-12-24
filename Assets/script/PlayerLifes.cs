
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerLifes : MonoBehaviour
{

    public int lives = 3;
    public Image[] livesUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            
            lives -= 1;
            Destroy(collision.gameObject);          
            if(lives <= 0){
                Debug.Log("You're Dead");
                Destroy(gameObject);
                SceneManager.LoadScene("gameover");
                
            }
          
        }
        
    }
}
