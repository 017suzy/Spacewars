using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifesP2 : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI; 

    void Start()
{

}

void Update()
{

}

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.collider.gameObject.tag == "Enemy")
    {
        Destroy(collision.collider.gameObject);
        lives -= 1;
        for(int i = 0; i < livesUI.Length; i++)
        {
            if(i < lives)
            {
                 livesUI[i].enabled = true;
            }
            else
            {
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