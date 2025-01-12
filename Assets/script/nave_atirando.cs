using UnityEngine;
using System.Collections;

public class nave_atirando : MonoBehaviour
{
    public float ClipLength = 1f;
    public GameObject AudioClip;
    public bool AllowedToShoot = true;
    public GameObject projectilePrefab;
    public float cronometer = 1f;

    void Start()
    {
        AudioClip.SetActive(false);
    }

    void Update()
    {
        if (!AllowedToShoot) return;

        cronometer -= Time.deltaTime;
        if (cronometer <= 0)
        {
            // Identifica se é a nave_0 ou nave_1 e aplica os controles específicos
            if (gameObject.name == "nave_0") // Player 1
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl))
                {
                    Atirar();
                }
            }
            else if (gameObject.name == "nave_1") // Player 2
            {
                if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
                {
                    Atirar();
                }
            }
        }
    }

    private void Atirar()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        StartCoroutine(PlayShootAudio());
        cronometer = 1f;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "barreira")
        {
            Destroy(gameObject);
        }
    }
}
