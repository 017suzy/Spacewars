using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Inimigo2Movimento : MonoBehaviour
{
    public float moveSpeed = 5;
    public float cronometer = 2;
    public GameObject explosionPrefab;

     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector2.down * moveSpeed * Time.deltaTime);
        cronometer -= Time.deltaTime;                
    }

    
    void OnTriggerEnter2D(Collider2D other){
     {
        if(other.gameObject.tag == "Player" || other.gameObject.tag =="balaPlayer"){    //|| other.gameObject.tag =="barreira" 
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

}