using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFunction : MonoBehaviour {

    public GameObject explsn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AntagonisticElement"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(explsn, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }
}
