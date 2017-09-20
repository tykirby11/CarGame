using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour {

    float speed = 10f;
    float torque = -2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetButton("Vertical"))
        {
            rb.AddForce(transform.up * speed);
        }

        rb.AddTorque(Input.GetAxis("Horizontal") * torque);
	}

}
