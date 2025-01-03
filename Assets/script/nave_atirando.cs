using UnityEngine;

public class nave_atirando : MonoBehaviour
{
    public bool AllowedToShoot = true;
    public GameObject projectilePrefab;
    public float cronometer = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AllowedToShoot == false) return;
        
        cronometer -= Time.deltaTime;
        if(cronometer<=0){
            if (Input.GetButtonDown("Fire1")){
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                cronometer = 1f;
            }
        }
        
    }

    public void AllowShooting(bool status)
    {
        AllowedToShoot = status;
    }

    void OnTriggerEnter2D(Collider2D other){
     {
        if(other.gameObject.tag =="barreira"){
            Destroy(gameObject);
        }
    }
}

}
    


