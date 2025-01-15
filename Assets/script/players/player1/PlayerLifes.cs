using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLifes : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public FloatValue currentHealth;
    public Signal playerHealthSignal;

    [SerializeField] private AudioClip damageaudioClip;
    private AudioSource audioSource;


    void Start(){
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        // Atualize a UI das vidas, se necessário
        for (int i = 0; i < livesUI.Length; i++)
        {
            livesUI[i].enabled = i < lives;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "balaInimigo")
        {
            currentHealth.RuntimeValue--;
            playerHealthSignal.Raise();
            Destroy(collision.gameObject);
            audioSource.clip = damageaudioClip;
            audioSource.Play();
            
            if (SceneManager.GetSceneByName("singleplayer").isLoaded || (SceneManager.GetSceneByName("BOSSFIGHT").isLoaded))
            {
                if (currentHealth.RuntimeValue < 0)
                {
                    Debug.Log("You're Dead");
                    Destroy(gameObject);
                    SceneManager.LoadScene("gameover");
                }
            }
            

            if (SceneManager.GetSceneByName("multiplayer").isLoaded || (SceneManager.GetSceneByName("BOSSFIGHT2").isLoaded))
            {
                if (currentHealth.RuntimeValue < 0)
                {
                    Debug.Log("You're Dead");
                    Destroy(gameObject);
                    SceneManager.LoadScene("gameover2");
                }
            }
        }
    }
}
