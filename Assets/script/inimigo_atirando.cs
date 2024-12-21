using UnityEngine;

public class inimigo_atirando : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float cronometer = 25;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<10; i++){
        cronometer -= Time.deltaTime;
            if(cronometer<=0){
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);  
            cronometer = 10;                      
            }
        }
        
    }
}
