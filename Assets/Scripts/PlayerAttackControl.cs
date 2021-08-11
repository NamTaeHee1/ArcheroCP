using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackControl : MonoBehaviour
{
    public static GameObject AttackTarget;

    private void Update() 
    {
        if(AttackTarget != null && FindObjectOfType<JoyStickControl>().isDragEnd)
            StartCoroutine(Attack());
        print(AttackTarget.name);
    }

    private IEnumerator Attack()
    {
        while(true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, AttackTarget.transform.rotation, 0.5f);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
