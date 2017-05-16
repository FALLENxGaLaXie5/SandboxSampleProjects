using UnityEngine;
using System.Collections;

public class CarDriver : MonoBehaviour {
    public float forwardSpeed = 5.0f;
    public float backwardSpeed = 2.0f;
    public float turnRate = 80.0f;

    public Rigidbody myRigidbody;

    public Transform lowestGroundObject;
    public Transform respawnPosition;

	// Use this for initialization
	public void Start () {
        this.myRigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	public void Update () {

        if(transform.position.y < lowestGroundObject.position.y) //respawn car, if it falls off the edge
        {
            transform.position = respawnPosition.position;
            transform.rotation = respawnPosition.rotation;
        }

        if(Input.GetKey(KeyCode.W)) //to move forward
        {
            transform.position += transform.forward * forwardSpeed * Time.deltaTime;
            //deltaTime gives consistent speed independent of framerate
            //transform.forward is direction
            //5.0f is 5.0 floating point (speed)
        }

        if (Input.GetKey(KeyCode.S)) //to move backward
        {
            transform.position -= transform.forward * backwardSpeed * Time.deltaTime;
            //deltaTime gives consistent speed independent of framerate
            //transform.forward is direction
            //5.0f is 5.0 floating point (speed)
        }

        if (Input.GetKey(KeyCode.A)) //to turn left
        {
            transform.Rotate(0.0f, -turnRate * Time.deltaTime, 0.0f); //rotation along X, Y, Z axis
        }

        if (Input.GetKey(KeyCode.D)) //to turn right
        {
            transform.Rotate(0.0f, turnRate * Time.deltaTime, 0.0f); //rotation along X, Y, Z axis
        }

        if (Input.GetKey(KeyCode.X)) //to set the car back up again, after the car rolls over
        {
            transform.position += Vector3.up;
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up); //sets the vehicle straight
        }


    }

 
}
