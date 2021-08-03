using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickControl : MonoBehaviour
{
    private float Radius;

    public Transform Stick;

    private Vector3 JoyStickVec;
    private Vector3 JoyStickFirstPosition;

    private void Start() 
    {
        Radius = GetComponent<RectTransform>().sizeDelta.x * 0.5f;
        JoyStickFirstPosition = Stick.transform.position;
    }

    public void Drag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Position = Data.position;

        JoyStickVec = (Position - JoyStickFirstPosition).normalized;

        float Distance = Vector3.Distance(Position, JoyStickFirstPosition);

        Stick.position = JoyStickFirstPosition + JoyStickVec * (Distance < Radius ? Distance : Radius);
    }

    public void DragEnd()
    {
        Stick.position = JoyStickFirstPosition;
        JoyStickVec = Vector3.zero;
    }
}
