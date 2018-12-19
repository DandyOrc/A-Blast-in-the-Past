using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndréJump : MonoBehaviour {

    public AudioClip MusicClip;

    public AudioSource MusicSource;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            MusicSource.Play();
	}
}
