using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource bossMusic; // Referência ao AudioSource da música do boss
    public AudioSource playMusic;

    // Método para parar a música do boss

    public void StopBossMusic()
    {
        if (bossMusic != null && bossMusic.isPlaying)
        {
            bossMusic.Stop();
        }
    }

    // Método para tocar a música de vitória
    public void PlayVictoryMusic(AudioSource victoryMusic)
    {
        StopBossMusic(); // Certifique-se de que a música do boss foi parada
        victoryMusic.Play(); // Toca a música de vitória
    }

    public void PlayBossMusic()
    {
        bossMusic.Play();
    }

    public void PlayMusic()
    {
        playMusic.Play();
    }

    public void StopPlayMusic()
    {
        if (playMusic != null && playMusic.isPlaying)
        {
            playMusic.Stop();
        }
    }
}
