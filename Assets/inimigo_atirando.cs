using UnityEngine;

public class inimigo_atirando : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float cronometer = 5;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        cronometer -= Time.deltaTime;
        if(cronometer<=0){
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);  
            cronometer = 5;                      
        }
    }
}
