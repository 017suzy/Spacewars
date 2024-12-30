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
        Debug.Log("Update chamado."); // Log básico para verificar o ciclo de vida do script.

    if (Input.GetKeyDown(KeyCode.Space)) // Teste com a barra de espaço.
    {
        Debug.Log("Barra de espaço pressionada!"); // Verifica se a entrada está funcionando.

        if (projectilePrefab != null)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Debug.Log("Projétil instanciado!");
        }
        else
        {
            Debug.LogError("Prefab do projétil não está atribuído no Inspector!");
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
    


