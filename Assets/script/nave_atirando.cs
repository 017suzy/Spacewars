using UnityEngine;

public class nave_atirando : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
        
    }
    
}
