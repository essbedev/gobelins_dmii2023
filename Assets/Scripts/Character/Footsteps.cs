using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class Footsteps : MonoBehaviour
{
[SerializeField]
    private PlayerMovement player;

    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.IsMoving() && player.IsGrounded() && !audio.isPlaying){
            audio.volume = Random.Range(.8f,1.0f);
            audio.pitch = Random.Range(.8f, 1.2f);
            audio.Play();
        }
    }
}
