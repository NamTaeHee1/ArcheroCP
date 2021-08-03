using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float h = 0;
    private float v = 0;
    private float MoveSpeed = 3.0f;

    private Transform PlayerTransform;

    private bool isMoving = false;

    private void Awake() 
    {
            PlayerTransform = GetComponent<Transform>();
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
            PlayerTransform.parent.transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * MoveSpeed);
    }

    private void PlayerRotate()
    {
        PlayerTransform.eulerAngles = new Vector3(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0);
    }
}
