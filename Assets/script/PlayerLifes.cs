
using UnityEngine;
using UnityEngine.UI;

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
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {  
            Destroy(collision.collider.gameObject);
            lives -= 1;
            for(int i = 0; i < livesUI.Length; i++){
                if(i < lives){
                    livesUI[i].enabled = true;
                }else{
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
