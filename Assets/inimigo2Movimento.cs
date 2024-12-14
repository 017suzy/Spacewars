using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Inimigo2Movimento : MonoBehaviour
{
    public float moveSpeed = 5;
    public float cronometer = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cronometer>0 && cronometer!=3){
            transform.Translate( Vector2.down * moveSpeed * Time.deltaTime);
            cronometer -= Time.deltaTime;
        }        
        else{
            while(cronometer<=3){
                moveSpeed = moveSpeed * -1;
                cronometer += Time.deltaTime;
            }
            
            
        }

        
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "barreira"){
            moveSpeed = moveSpeed * -1;
        }
        
    }
}
