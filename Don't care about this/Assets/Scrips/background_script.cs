using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_script : MonoBehaviour {

    public float speed;
    private float pos;

    void Update()
    {
        pos = +speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos, 0);
    }
}
