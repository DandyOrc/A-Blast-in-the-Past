using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "Lava block")
        {
                SceneManager.LoadScene("A blast in the past");
        }
    }
}


