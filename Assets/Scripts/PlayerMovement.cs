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
        GetAxis();
        PlayerMove();
    }

    private void GetAxis()
    {
        h = FindObjectOfType<JoyStickControl>().JoyStickVec.x;
        v = FindObjectOfType<JoyStickControl>().JoyStickVec.y;
    }

    private void PlayerMove()
    {
        PlayerTransform.Translate(new Vector3(h, 0, v) * Time.deltaTime * MoveSpeed);
    }
}
