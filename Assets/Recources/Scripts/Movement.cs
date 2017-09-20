using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10f;
    public float rotationSpeed = 5f;
    public float torque = -2f;


    private Rigidbody2D theRigidbody;


	// Use this for initialization
	void Start () {
        theRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        float inputX = Input.GetAxis("Vertical");
        float inputZ = Input.GetAxis("Horizontal");
       // Debug.Log(inputX);
        //theRigidbody.velocity = new Vector2(inputX * speed, theRigidbody.velocity.y);

        //transform.Rotate(Vector3.forward, inputZ * rotationSpeed);

        if (Input.GetButton("Vertical")) {
            theRigidbody.AddForce(transform.up * speed);
        }

        theRigidbody.AddTorque(inputZ * torque);
    }
    
}
