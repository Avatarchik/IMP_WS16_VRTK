using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GnomeManager : MonoBehaviour {

    public GameObject gnome;
    public float spawnTime = 3f;
    public Transform[] spawnPoints; 

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn () {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(gnome, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
