using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntagonisticShooting : MonoBehaviour {

    public float bulletSpeed, tempTime;
    public float bulletDestroyTime;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public GameObject explsn;

    public float distance;
    public Transform MainCharacter;

    public bool shoot;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        distance = Vector3.Distance(transform.position, MainCharacter.position);

        if (distance < 20)
        {
            tempTime += Time.deltaTime;
            if (tempTime > 2)
            {
                tempTime = 0;
                Fire();

            }
        }

        
    }

    void Fire()
    {
        Instantiate(explsn, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        Destroy(bullet, bulletDestroyTime);
    }
}