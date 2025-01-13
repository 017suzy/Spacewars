using UnityEngine;
using UnityEngine.SceneManagement;

public class isdeadp1 : MonoBehaviour
{
    public GameObject player1;


    void Update()
    {
        Isdead();
    }

    public void Isdead()
    {
        if (player1 == null)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
