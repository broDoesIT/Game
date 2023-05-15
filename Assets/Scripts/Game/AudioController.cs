using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip BackgroundMusic;
    public AudioClip CoinSound;
    public AudioClip Bomsound;
    public AudioClip Eatsound;
    AudioSource[] Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponents<AudioSource>();
        Audio[0].Play();
        Audio[0].volume = 0.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAudiocoin()
    {
        Audio[1].PlayOneShot(CoinSound);
    }
    public void playAudiobom()
    {
        Audio[2].PlayOneShot(Bomsound);
    }

    public void playEatSound()
    {
        Audio[3].PlayOneShot(Eatsound);
    }

    public void PauseAudio()
    {
        Audio[0].Pause();
    }

    public void StopAudio() 
    {
        Audio[0].Stop();
    }
    public void Unpause()
    {
        Audio[0].UnPause();
    }
}
