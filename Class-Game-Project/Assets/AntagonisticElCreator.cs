using System.Collections;
using System.Collections.Generic;
using UnityEngine;





 public class AntagonisticElCreator : MonoBehaviour
{

    public GameObject AntagonisticElement;

    public int MaxCounter;
    public int CounterStatus;
    int numberofEnemy;
    // Use this for initialization

    void Start()
    {
        CounterStatus = 0;
        numberofEnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (CounterStatus <= 0)
        {
            if (numberofEnemy < 3)
            {
                Vector3 creationPoint = transform.position;
                creationPoint.y = -0.5f;
                Instantiate(AntagonisticElement, creationPoint, transform.rotation);

                CounterStatus = MaxCounter;
                numberofEnemy++;
            }
        }


        else
        {
            CounterStatus--;
        }



    }


}


/*
 public class AntagonisticElCreator : MonoBehaviour {

    public GameObject boom;
    public float enemySpeed, distance;
    public bool move, shoot;
    public Transform character;
    Vector3 pos;
    int boomnumber;


    void Start () {
       
    }

    // Update is called once per frame
    void Update() {


        pos = new Vector3(character.position.x, transform.position.y, character.position.z);
        distance = Vector3.Distance(transform.position, character.position);
        if (distance < 20){
            move = true;
            shoot = false;
            transform.LookAt(pos);

        }
        if (distance < 10)
        {
            move = false;
            shoot = true;
            
            
        }

        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, character.position, enemySpeed * Time.deltaTime);
            transform.LookAt(pos);
        }
        if (shoot)
        {
            if (boomnumber < 5)
            {
                Instantiate(boom, new Vector3(transform.position.x + 0.15f, transform.position.y + 1.9692f, transform.position.z + 3.69f), this.gameObject.transform.rotation);
                boomnumber++;
            }
        }


    }

    
	}
 * */
