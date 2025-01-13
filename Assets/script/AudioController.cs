using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource bossMusic; // O AudioSource para a música do boss
    public AudioSource victoryMusic; // O AudioSource para a música de vitória

    // Chame esta função ao ativar o Canvas de vitória
    public void PlayVictoryMusic()
    {
        if (bossMusic.isPlaying)
        {
            bossMusic.Stop(); // Para a música do boss
        }

        if (!victoryMusic.isPlaying)
        {
            victoryMusic.Play(); // Toca a música de vitória
        }
    }
}
