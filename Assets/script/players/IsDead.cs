using UnityEngine;
using UnityEngine.SceneManagement;

public class IsDead : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    

    // Update is called once per frame
    void Update()
    {
        Isdead();
        
    }

    public void Isdead()
    {
        if (player1 == null && player2 == null)
        {
            SceneManager.LoadScene("gameover2");
        }
    }
}
