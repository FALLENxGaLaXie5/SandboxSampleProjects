using UnityEngine;
using System.Collections;

public class PlanePilot : MonoBehaviour {
    // adjust speed based on the incline of the PlaneWhole (slow when up, and fast when down)
    public float speed = 15.0f;


	// Use this for initialization
	void Start () {
        Debug.Log("PlanePilot Script added to " +gameObject.name);
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * speed * Time.deltaTime; //to move the plane

        speed -= transform.forward.y * Time.deltaTime * 2.0f; //forward points to front of the plane, decreasing when going up, and increasing when going down
        //times 2, to make the effect more apparent

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -1.0f*Input.GetAxis("Horizontal")); //X, Y and Z axis
        //this one has no Yaw for the PlaneWhole - only X and Z axis rotations
        //GetAxis is automatically connected to multiple inputs: WASD and Arrow-Keys.

        //prevent PlaneWhole from flying through the ground
        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);
        //Terrtain.activeTerrain is the main active terrain in the scene
        //SampleHeight gives current height of the terrain

        if(terrainHeightWhereWeAre > transform.position.y) //identify if our PlaneWhole crashed into ground
            {
            transform.position = new Vector3(transform.position.x, terrainHeightWhereWeAre, transform.position.z); //X, Y & Z coordinates
            }
	}
}
