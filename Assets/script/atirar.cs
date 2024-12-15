//using System.Collection
//using System.Collections.Generic;
using UnityEngine;

public class atirar : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "barreira"){
             Destroy(gameObject);
       }
    }
}
