using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Inimigo1Movimento : MonoBehaviour
{
    public float moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector2.right * moveSpeed * Time.deltaTime);

        
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
