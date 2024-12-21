using UnityEngine;

public class nave_atirando : MonoBehaviour
{
    public bool AllowedToShoot = true;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AllowedToShoot == false) return;
        if (Input.GetButtonDown("Fire1")){
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
        
    }

    public void AllowShooting(bool status)
    {
        AllowedToShoot = status;
    }
    
}
