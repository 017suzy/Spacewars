using UnityEngine;
using UnityEngine.UI;

public class changeLives2 : MonoBehaviour
{
    public PlayerLifes pLive;
    public Sprite vidasOn;
    public Sprite vidasOff;
    public SpriteRenderer SpriteRenderer;
    public Image vidaAtual;
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {       
        vidaAtual = GetComponent<Image>();
        
    }

     void ChangeSprite()
    {
        vidaAtual.sprite = vidasOff;

    }

    // Update is called once per frame
    void Update()
    {
        if (pLive.lives <= 2){
            ChangeSprite();
        }
        
    }
}
