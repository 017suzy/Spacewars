//using System.Collection
//using System.Collections.Generic;
using UnityEngine;

public class atirar : MonoBehaviour
{
    public float moveSpeed;
    private PointManeger pointManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointManager = GameObject.Find("PointManeger").GetComponent<PointManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "barreira"){
             Destroy(gameObject);
       }
    }
}
