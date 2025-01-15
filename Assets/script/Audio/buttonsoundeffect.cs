using UnityEngine;

public class buttonsoundeffect : MonoBehaviour
{   public AudioSource soundPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playThisSoundEffect(){
        soundPlayer.Play();
    }
}
