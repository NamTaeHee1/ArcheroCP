using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float h = 0;
    private float v = 0;
    private float MoveSpeed = 3.0f;

    private Transform PlayerTransform;

    private Rigidbody PlayerRigidbody;

    private bool isMoving = false;

    private void Awake() 
    {
            PlayerTransform = GetComponent<Transform>();
            PlayerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        GetAxis();
        PlayerMove();
        PlayerRotate();
    }

    private void GetAxis()
    {
        h = FindObjectOfType<JoyStickControl>().JoyStickVec.x;
        v = FindObjectOfType<JoyStickControl>().JoyStickVec.y;
        isMoving = (h != 0 || v != 0) ? true : false;
    }

    private void PlayerMove()
    {
        if(isMoving)
            PlayerTransform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
    }

    private void PlayerRotate()
    {
        PlayerRigidbody.rotation = Quaternion.LookRotation(new Vector3(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0));
    }
}
