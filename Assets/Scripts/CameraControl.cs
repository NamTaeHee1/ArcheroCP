using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private GameObject Target;

    [SerializeField] private Vector3 Offset;
    private void LateUpdate()
    {
        Vector3 CameraPosition = Vector3.Lerp(transform.position, Target.transform.position + Offset, 0.1f);
        CameraPosition.x = 0;

        transform.position = CameraPosition;
    }
}
