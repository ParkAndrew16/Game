using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    private Rigidbody player;
    public float speed = 1f;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello");

        player = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
        {
            player.position = player.position + new Vector3(0, 0, speed);
        }

        if (Input.GetKey("a"))
        {
            player.position = player.position + new Vector3(-speed, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            player.position = player.position + new Vector3(0, 0, -speed);
        }

        if (Input.GetKey("d"))
        {
            player.position = player.position + new Vector3(speed, 0, 0);
        }

    }
}
