using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float h = 0;
    private float v = 0;
    private float MoveSpeed = 3.0f;

    private Rigidbody PlayerRigidbody;

    private void Awake() 
    {
            PlayerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        GetAxis();
        PlayerMove();
    }

    private void GetAxis()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    private void PlayerMove()
    {
        PlayerRigidbody.velocity = new Vector3(h, 0, v) * MoveSpeed * Time.deltaTime;
    }
}
