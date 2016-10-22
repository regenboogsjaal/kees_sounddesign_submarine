using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PlayAudio : MonoBehaviour {
	
    void OnTriggerEnter(Collider Player){
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

    }
	
	void OnTriggerExit(Collider Player){
        AudioSource audio = GetComponent<AudioSource>();
        audio.Stop();

    }
}