using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Audio : MonoBehaviour
{
    protected AudioSource audioSource;
    // Start is called before the first frame update
    public abstract void PlayClip(AudioClip audioClip);
    public abstract void StopCurrentClip();
}
