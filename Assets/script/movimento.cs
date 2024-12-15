using UnityEngine;

public class Enime3mov : MonoBehaviour
{
    public float speed = 1;
    public float timer = 0;
    public bool direita = true;
    public bool esquerda = false;
    public bool cima = false;
    public bool baixo = false;

    void Update()
    {
        if(direita == true && timer >= 1500) {
            timer = 0;
        }
        if(direita == true && timer < 600){
            transform.position += Vector3.right * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            direita = false;
            baixo = true;
        }
        if(baixo == true && timer < 750 && timer >= 599){
            transform.position += Vector3.down * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            baixo = false;
            esquerda = true;
        }
        if(esquerda == true && timer < 1350 && timer >= 749){
            transform.position += Vector3.left * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            esquerda = false;
            cima = true;
        }
        if(cima == true && timer < 1500 && timer >= 1349){
            transform.position += Vector3.up  * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            cima = false;
            direita = true;
        }
        
    }

}