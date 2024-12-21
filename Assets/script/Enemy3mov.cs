using UnityEngine;

public class Enime3mov : MonoBehaviour
{
    public float speed = 5;
    public float timer = 0;
    public bool direita = true;
    public bool esquerda = false;
    public bool cima = false;
    public bool baixo = false;

    void Update()
    {
        if(direita == true && timer >= 300) {
            timer = 0;
        }
        if(direita == true && timer < 120){
            transform.position += Vector3.right * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            direita = false;
            baixo = true;
        }
        if(baixo == true && timer < 150 && timer >= 119){
            transform.position += Vector3.down * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            baixo = false;
            esquerda = true;
        }
        if(esquerda == true && timer < 270 && timer >= 149){
            transform.position += Vector3.left * speed * Time.deltaTime;
            timer = timer + 1;
        }else{
            esquerda = false;
            cima = true;
        }
        if(cima == true && timer < 300 && timer >= 269){
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
        if(other.gameObject.tag == "barreira"){
            Destroy(gameObject);
        }
    }

}
