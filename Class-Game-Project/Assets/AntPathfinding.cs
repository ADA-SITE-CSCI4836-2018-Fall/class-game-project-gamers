using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AntPathfinding : MonoBehaviour {

    public GameObject characterRef;
    
   
    // Use this for initialization

    //Navmeshagent which belongs to object
    private NavMeshAgent agent;
	void Start () {
        //take object
        agent = GetComponent<NavMeshAgent>();
       
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(characterRef.transform.position);
	}
}
