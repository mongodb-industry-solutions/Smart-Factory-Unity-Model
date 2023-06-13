using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonSound : MonoBehaviour
{
    public AudioSource audio;

    public void SoundOnClick()
    {
        audio.Play();
    }
}
