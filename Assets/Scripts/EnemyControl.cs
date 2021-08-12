using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyControl : MonoBehaviour
{
    int HP;

    public void Die()
    {
        GoldManager.Gold += 15;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Bullet"))
        {
            HP -= FindObjectOfType<BulletControl>().ButtletDamage;
            if(HP <= 0)
                Die();
        }
    }
}

