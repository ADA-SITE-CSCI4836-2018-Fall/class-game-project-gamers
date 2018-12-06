using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour {

    // Use this for initialization
    public AudioSource Pr;
    // Use this for initialization
    void Start()
    {
        Pr = GetComponent<AudioSource>();
        Pr.volume = 0;
    }

    // Update is called once per frame
    void Update () {
		if(Pr.volume == 1)
        {
            Pr.volume = Pr.volume - 0.05f;
        }
	}

    void OnTriggerEnter(Collider other)
    {
      
            if (other.CompareTag("MainCharacter"))
            {
               
                   
                    Pr.volume = 1;
                


            }
        }
    }
