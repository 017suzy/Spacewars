using UnityEngine;
using System.Collections; // Necessário para usar coroutines

public class inimigo_atirando : MonoBehaviour
{
    public float cronometer = 3f;
    public GameObject projectilePrefab;

    // Variáveis para o som
    public GameObject AudioClip; // O GameObject responsável pelo som
    public float ClipLength = 1f; // Duração do som

    void Start()
    {
        if (AudioClip != null)
        {
            AudioClip.SetActive(false);
        }
    }

    void Update()
    {
        cronometer -= Time.deltaTime;
        if (cronometer <= 0)
        {
            // Dispara o projétil
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // Reproduz o som
            if (AudioClip != null)
            {
                StartCoroutine(PlayShootAudio());
            }

            // Reseta o cronômetro
            cronometer = 3f;
        }
    }

    private IEnumerator PlayShootAudio()
    {
        AudioClip.SetActive(true);
        yield return new WaitForSeconds(ClipLength);
        AudioClip.SetActive(false);
    }
}
