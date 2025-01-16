using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MudancaCenas : MonoBehaviour
{
    private AudioSource _audioSource;
    

    void Start()
    {
        DontDestroyOnLoad(gameObject); // Garante que este objeto não será destruído ao mudar de cena
        _audioSource = GetComponent<AudioSource>();
    }

    public void TrocaCena(string sceneName)
    {
        StartCoroutine(PlaySoundAndChangeScene(sceneName));
        
    }

    IEnumerator PlaySoundAndChangeScene(string sceneName)
    {
        // Toca o som
        if (_audioSource != null && _audioSource.clip != null)
        {
            _audioSource.Play();
            yield return new WaitForSeconds(_audioSource.clip.length * 0.1f); // Aguarda o som terminar
        }

        // Após o som, inicia o carregamento da cena
        yield return StartCoroutine(LoadAsynchronously(sceneName));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 1f); // Normaliza o progresso entre 0 e 1
            yield return null;
        }

    }
}

