using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public GameObject[] AntagonisticElements;
    public GameObject[] Doors;
    public int numberofenemy;

    public AudioSource Pr;
	// Use this for initialization
	void Start () {
        Pr = GetComponent<AudioSource>();
        Pr.volume = 0;
    }
	
	// Update is called once per frame
	void Update () {
        AntagonisticElements = GameObject.FindGameObjectsWithTag("AntagonisticElement");
        numberofenemy = AntagonisticElements.Length;


       

    }

    void OnTriggerEnter(Collider other)
    {
    if (numberofenemy == 3)
    {
        if (other.CompareTag("MainCharacter"))
        {
                Doors = GameObject.FindGameObjectsWithTag("Door");

                for (var i = 0; i < Doors.Length; i++)
                {
                    Doors[i].SetActive(false);
                    Pr.volume = 1;

                }
                

            }
    }
    }
}
