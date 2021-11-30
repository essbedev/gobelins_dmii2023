using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TreeDetection : MonoBehaviour
{

    public AudioMixerSnapshot Inside;
    public AudioMixerSnapshot Outside;

    void OnTriggerEnter(Collider other){
        Inside.TransitionTo(.5f);
    }

    void OnTriggerExit(Collider other){
        Outside.TransitionTo(.5f);
    }
}
