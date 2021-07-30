using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float h = 0;
    private float v = 0;
    private float MoveSpeed = 3.0f;

    private Transform PlayerTransform;

    private void Awake() 
    {
            PlayerTransform = GetComponent<Transform>();
    }


    void Update()
    {
        PlayerMove();
    }

    private void GetAxis()
    {
        
    }

    private void PlayerMove()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        PlayerTransform.Translate(new Vector3(h, 0, v) * MoveSpeed * Time.del);
    }
}
