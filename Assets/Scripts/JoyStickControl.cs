using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickControl : MonoBehaviour
{
    private float Radius;

    public Transform BGStick;
    public Transform SmallStick;

    public Vector3 JoyStickVec;
    private Vector3 JoyStickFirstPosition;
    [SerializeField] private Vector3 JoyStickResetPosition;

    public bool isDragEnd;

    private void Start() 
    {
        Radius = BGStick.gameObject.GetComponent<RectTransform>().sizeDelta.x * 0.5f;
        JoyStickFirstPosition = SmallStick.transform.position;
    }

    public void PointerDown()
    {
        isDragEnd = false;
        BGStick.position = Input.mousePosition;
        SmallStick.position = Input.mousePosition;
        JoyStickFirstPosition = Input.mousePosition;
    }

    public void Drag(BaseEventData _Data)
    {
        isDragEnd = false;
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Position = Data.position;

        JoyStickVec = (Position - JoyStickFirstPosition).normalized;

        float Distance = Vector3.Distance(Position, JoyStickFirstPosition);

        SmallStick.position = JoyStickFirstPosition + JoyStickVec * (Distance < Radius ? Distance : Radius);
    }

    public void DragEnd()
    {
        BGStick.position = JoyStickResetPosition;
        SmallStick.position = JoyStickResetPosition;
        JoyStickVec = Vector3.zero;
        isDragEnd = true;
    }
}
