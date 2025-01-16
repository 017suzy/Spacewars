using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLifes1 : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public FloatValue1 currentHealth2;
    public Signal1 playerHealthSignal2;
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
        if (collision.gameObject.tag == "Enemy")
        {
            audioSource.Play();
            currentHealth2.RuntimeValue1--;
            playerHealthSignal2.Raise();
            Destroy(collision.gameObject);
            
            if (currentHealth2.RuntimeValue1 < 0)
            {
                Debug.Log("You're Dead");
                Destroy(gameObject);
                SceneManager.LoadScene("gameover2");
            }
        }


        if (collision.gameObject.tag == "balaInimigo")
        {
            audioSource.clip = damageaudioClip; //////////////////////
            audioSource.Play();
            currentHealth2.RuntimeValue1--;
            playerHealthSignal2.Raise();
            Destroy(collision.gameObject);
            
            if (currentHealth2.RuntimeValue1 < 0)
            {
                Debug.Log("You're Dead");
                Destroy(gameObject);
                SceneManager.LoadScene("gameover2");
            }
        }
    }
}

