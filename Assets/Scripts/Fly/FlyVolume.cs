using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FlyVolume : MonoBehaviour
{

    public AudioMixer mixer;

    void Update()
    {
        mixer.SetFloat("insectVolume", Mathf.Sin(Time.time)*10.0f);
    }
}
