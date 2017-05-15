using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    //goal of this program is to randomly pick a respawn point to respawn the player

    public Transform playerSpawnPoints; //  the parent of the spawn points
    public bool reSpawn = false;

    private Transform[] spawnPoints;
    private bool lastToggle = false;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoints.Length); //returns count of Player Spawn Points and all of its children 
	}
	
	// Update is called once per frame
	void Update () {
	    if(lastToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        }
        else { lastToggle = reSpawn; }
        

	}

    private void Respawn() // only Player will use this method
    {
        int i = Random.Range(1, spawnPoints.Length); //takes a random value between 1 and spawnPoints.Length
        transform.position = spawnPoints[i].transform.position;
    }
}
