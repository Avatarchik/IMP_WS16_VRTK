using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GnomeMovement : MonoBehaviour {

    Transform player;
    NavMeshAgent nav;


    // Use this for initialization
    void Awake () {
        player = GameObject.FindWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(player.position);
	}
}
