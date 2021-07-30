using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]    private GameObject Target;

    private void Update()
    {
        Transform.Lerp(Transform.position, Target.transform.position, 0.5f);
    }
}
