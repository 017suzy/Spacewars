using UnityEngine;

public class projetilInimigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 2 * speed)   ;
     
        
    }
    void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.tag == "Player" || other.gameObject.tag == "barreira"){
                Destroy(gameObject);
            }
        }
}
