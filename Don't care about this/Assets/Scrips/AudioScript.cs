using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    public AudioClip MusicClip;
    public AudioSource MusicSource;

	void Start () {
        MusicSource.clip = MusicClip;
	}
	
	void Update () {
   
	}
}
