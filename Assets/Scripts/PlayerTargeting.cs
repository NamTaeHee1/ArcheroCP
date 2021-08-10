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
        for(int i = 0; i < HitEnemyColliders.Length; i++)
            print(HitEnemyColliders[i].transform.name);
    }

    private void CheckEnemyCollider()
    {
        HitEnemyColliders = Physics.OverlapSphere(transform.position, 6.0f, EnemyLayerMask);
    }

}
