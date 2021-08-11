using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTargeting : MonoBehaviour
{
    private PlayerTargeting instance;
    public Collider[] HitEnemyColliders;

    private LayerMask EnemyLayerMask;

    private void Awake() 
    {
        EnemyLayerMask = LayerMask.GetMask("Enemy");
    }

    private void FixedUpdate() 
    {
        CheckEnemyCollider();
        if(HitEnemyColliders.Length != 0)
            PlayerAttackControl.AttackTarget = SelectTarget();
    }

    private void CheckEnemyCollider()
    {
        HitEnemyColliders = Physics.OverlapSphere(transform.position, 6.0f, EnemyLayerMask);
    }

    public GameObject SelectTarget()
    {
        GameObject NearTarget = HitEnemyColliders[0].transform.gameObject;

        return NearTarget;
    }

}
