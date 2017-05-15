using UnityEngine;
using System.Collections;

public class ZombieRun : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("1"))
        {
            GetComponent<Animation>().Play("sprint_left");
        }

        if (Input.GetKeyDown("2"))
        {
            GetComponent<Animation>().Play("zombie_attack");
        }
    }
}
