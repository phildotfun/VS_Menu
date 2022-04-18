using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip earthquake;

    public void PlayEarthquake()
    {
        audioSource.PlayOneShot(earthquake);
    }
}
