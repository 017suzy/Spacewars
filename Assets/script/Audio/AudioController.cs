using UnityEngine;

public class AudioController : MonoBehaviour
{
    //public AudioSource bossMusic; // Referência ao AudioSource da música do boss
    public AudioSource playMusic;
    public AudioClip music;

    // Método para parar a música do boss

    // Método para tocar a música de vitória
    public void PlayVictoryMusic(AudioSource victoryMusic)
    {
        StopPlayMusic(); // Certifique-se de que a música do boss foi parada
        victoryMusic.Play(); // Toca a música de vitória
    }


    public void PlayMusic(bool resetSong, AudioClip music = null)
    {
        if (music != null)
        {
            playMusic.clip = music;
        }
        else if (playMusic.clip != null)
        {
            if (resetSong)
            {
                playMusic.Stop();
            }
            playMusic.Play();
        }
        
    }

    public void StopPlayMusic()
    {
        playMusic.Pause();
    }
}
