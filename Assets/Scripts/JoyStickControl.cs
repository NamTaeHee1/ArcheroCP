using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickControl : MonoBehaviour
{
    private float Radius;

    public Transform Stick;

    private Vector3 JoyStickVec;
    private Vector3 JoyStickFirstPosition;

    private void Awake() 
    {
        JoyStickFirstPosition = Stick.transform.position;
    }

    public void Drag()
    {

    }
}
