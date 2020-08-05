using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : Audio
{
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void PlayClip(AudioClip audioClip)
    {
        StopCurrentClip();
        audioSource.PlayOneShot(audioClip);
    }

    public override void StopCurrentClip()
    {
        audioSource.Stop();
    }
}
