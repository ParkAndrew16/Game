using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    private Rigidbody player;
    private Collider onGround;
    private float speed = 0.0f;
    public float walkingSpeed = 0.1f;
    public float runningSpeed = 0.3f;
    public float jumpHeight = 2f;


    // Use this for initialization
    void Start () {
        Debug.Log("Hello");

        player = GetComponent<Rigidbody>();
        onGround = GetComponentInChildren<Collider>();
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

        if (Input.GetKey("left shift") || Input.GetKey("right shift"))
        {
            speed = runningSpeed;
        }
        else
        {
            speed = walkingSpeed;
        }

        if (Input.GetKey("space") && player.velocity.y == 0)
        {
            player.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Acceleration);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        //
    }
}
