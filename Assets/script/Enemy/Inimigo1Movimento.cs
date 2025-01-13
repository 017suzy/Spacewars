using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class inimigo2Movimento : MonoBehaviour
{
    private float dirX;
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector3 localScale;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
        moveSpeed = 3f;
    }



    

    // Update is called once per frame
    //void Update()
    //{
     //   transform.Translate( Vector2.right * moveSpeed * Time.deltaTime);

        
    //}

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="barreira")
        {
            dirX *= -1f;  
        }       
                
    
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(dirX*moveSpeed, rb.linearVelocityY);
    }

}
