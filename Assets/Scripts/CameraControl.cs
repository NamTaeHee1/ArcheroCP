using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]    private GameObject Target;
    private void LateUpdate()
    {
        Vector3 CameraPosition = Vector3.Lerp(transform.position, Target.transform.position, 0.5f);
        CameraPosition = new Vector3(0, 13f, CameraPosition.z);

        transform.position = CameraPosition;
    }
}
