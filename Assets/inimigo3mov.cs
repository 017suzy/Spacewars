using UnityEngine;

public class Inimigo3mov : MonoBehaviour
{
    public float speed = 5;
    public float timer = 0;
    public bool direita = true;
    public bool esquerda = false;
    public bool cima = false;
    public bool baixo = false;

    void Update()
    {
    
    if(direita == true && timer >= 150) {
        timer = 0;
    }

    if(direita == true && timer < 60){
        transform.position += Vector3.right * speed * Time.deltaTime;
        timer = timer + 1;
    }else{
        direita = false;
        baixo = true;
    }
    if(baixo == true && timer < 75 && timer >= 59){
        transform.position += Vector3.down * speed * Time.deltaTime;
        timer = timer + 1;
    }else{
        baixo = false;
        esquerda = true;
    }
    if(esquerda == true && timer < 135 && timer >= 74){
        transform.position += Vector3.left * speed * Time.deltaTime;
        timer = timer + 1;
    }else{
        esquerda = false;
        cima = true;
    }
    if(cima == true && timer < 150 && timer >= 134){
        transform.position += Vector3.up  * speed * Time.deltaTime;
        timer = timer + 1;
    }else{
        cima = false;
        direita = true;
    }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
        
        if(other.gameObject.tag == "balaPlayer"){
            Destroy(gameObject);
        }
    
    }
}
