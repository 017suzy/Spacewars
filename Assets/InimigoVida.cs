using UnityEngine;
using UnityEngine.UI;

public class InimigoVida : MonoBehaviour
{
    public Image barraVida;
    private PointManeger pointManager;
    public float vida;
    public float vidaCheia = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaCheia = vida;  
        pointManager = GameObject.Find("PointManeger").GetComponent<PointManeger>();
 
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "balaPlayer"){
            vida = vida - 2;

        }
        if(vida < 0){            
            Destroy(gameObject);
            pointManager.UpdateScore(100);
            barraVida.enabled = false;
        }

    }
}