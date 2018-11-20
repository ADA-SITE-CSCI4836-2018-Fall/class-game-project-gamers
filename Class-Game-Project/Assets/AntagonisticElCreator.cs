using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntagonisticElCreator : MonoBehaviour {

    public GameObject AntagonisticElement;

    public int MaxCounter;
    public int CounterStatus;
    
    // Use this for initialization

    void Start () {
        CounterStatus = 0;
      
    }

    // Update is called once per frame
    void Update() {


        if (CounterStatus <= 0)
        {

            Vector3 creationPoint = transform.position;
            creationPoint.y = -0.5f;
            Instantiate(AntagonisticElement, creationPoint, transform.rotation);

            CounterStatus = MaxCounter;
        }


        else
        {
            CounterStatus--;
        }



    }

    
	}

