using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class MoveTank : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDestroyTime;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public GameObject explsn;
    public float speedMove = 1.0F;
    public float speedRotate = 0.5F;
    public int NumbarofBullet;
    public GameObject Bomb;

    private void Start()
    {
        bulletSpeed = 15f;
    bulletDestroyTime = 8f;
        NumbarofBullet = 25;
}
    void Update()
    {
        CharacterController cntrlr = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * speedRotate, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speedMove * Input.GetAxis("Vertical");
        cntrlr.SimpleMove(forward * curSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
            {
            var a = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
         Instantiate(Bomb, a, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (NumbarofBullet > 0)
            {

                Fire();
                NumbarofBullet--;
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
