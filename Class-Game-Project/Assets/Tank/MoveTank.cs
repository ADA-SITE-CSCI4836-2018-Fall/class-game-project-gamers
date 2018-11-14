using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class MoveTank : MonoBehaviour
{
    public float speedMove = 1.0F;
    public float speedRotate = 0.5F;

    void Update()
    {
        CharacterController cntrlr = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * speedRotate, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speedMove * Input.GetAxis("Vertical");
        cntrlr.SimpleMove(forward * curSpeed);
    }
}