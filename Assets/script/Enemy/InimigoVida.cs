using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InimigoVida : MonoBehaviour
{
    public Image barraVida;
    private PointManeger pointManager;
    public float vida;
    public float vidaCheia = 100;
    public GameObject explosionPrefab;
    public GameObject victorypanel;
    [SerializeField] private AudioClip damageaudioClip;
    private AudioSource audioSource;

    public AudioController vitoria;

    
    void Start()
    {
        vidaCheia = vida;  
        pointManager = GameObject.Find("PointManeger").GetComponent<PointManeger>();
        audioSource = GetComponent<AudioSource>(); 
 
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.fillAmount = Mathf.Clamp(vida / vidaCheia,0,1);

        
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "balaPlayer"){
            vida = vida - 2;
            audioSource.clip = damageaudioClip;
            audioSource.Play();

        }
        if(vida < 0){ 
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);           
            Destroy(gameObject);
            pointManager.UpdateScore(100);
            barraVida.enabled = false;
            Time.timeScale = 0f;
            vitoria.StopBossMusic();
            victorypanel.SetActive(true);
        }

    }
}
