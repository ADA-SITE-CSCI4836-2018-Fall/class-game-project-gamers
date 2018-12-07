using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class MoveTank : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDestroyTime;
    public float MainHealth;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public GameObject explsn;
    public float speedMove = 1.0F;
    public float speedRotate = 0.5F;
    private int NumbarofBullet;
    public GameObject Bomb;
    public GUIStyle styleofBulletLabel;
    public GUIStyle styleofBombLabel;
    public GUIStyle styleofHealthLabel;
    private int numberofBombs;
    public GameObject[] AntagonisticElements;
    public int numberofenemy;
    private void Start()
    {
        bulletSpeed = 15f;
    bulletDestroyTime = 8f;
        NumbarofBullet = 15;
        numberofBombs = 5;
        MainHealth = 100;
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
            
            if (numberofBombs > 0)
            {
                var a = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
                Instantiate(Bomb, a, Quaternion.identity);
                numberofBombs--;
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (NumbarofBullet > 0)
            {

                Fire();
                NumbarofBullet--;
            }
        }

        AntagonisticElements = GameObject.FindGameObjectsWithTag("AntagonisticElement");
        numberofenemy = AntagonisticElements.Length;

       

    }
    void Fire()
    {
        Instantiate(explsn, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);       
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        Destroy(bullet, bulletDestroyTime);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, Screen.width, 50),"Bullets: " + NumbarofBullet, styleofBulletLabel);
        GUI.Label(new Rect(0, 0, Screen.width, 50), "Bombs: " + numberofBombs, styleofBombLabel);
        GUI.Label(new Rect(0, 0, Screen.width, 50), "Health: " + MainHealth, styleofHealthLabel);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Source"))
        {


            numberofBombs = 5;
            NumbarofBullet = 15;
            MainHealth = 100;


        }

        if (other.CompareTag("BulletEnemy"))
        {


            MainHealth = MainHealth - 10;
            if(MainHealth <= 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("Menu");
            }



        }
    }


    
          
    }




