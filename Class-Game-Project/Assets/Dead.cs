using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour {

    public int healht;
    public int deadenemy;
    public GUIStyle styleofEnemyLabel;
    // Use this for initialization
    void Start () {
        healht = 100;
        deadenemy = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag== "Bullet")
        {

            healht = healht - 50;
            Destroy(other.gameObject);
           
            if (healht <= 0)
            {
                deadenemy = deadenemy + 1;
                Destroy(gameObject);
               

            }
            
        }

    }
    

}
