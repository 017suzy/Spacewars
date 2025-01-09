using UnityEngine;
using System.Collections;


public class nave_atirando : MonoBehaviour
{   
     public float ClipLength = 1f;

    public GameObject AudioClip;
    public bool AllowedToShoot = true;
    public GameObject projectilePrefab;
    public float cronometer = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioClip.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (AllowedToShoot == false) return;
        
        cronometer -= Time.deltaTime;
        if (cronometer <= 0)
        {
    if (Input.GetButtonDown("Fire1"))
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        StartCoroutine(PlayShootAudio());
        cronometer = 1f;
    }
            }
        
    }
    private IEnumerator PlayShootAudio()
{
    AudioClip.SetActive(true);
    yield return new WaitForSeconds(ClipLength);
    AudioClip.SetActive(false);
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
    


