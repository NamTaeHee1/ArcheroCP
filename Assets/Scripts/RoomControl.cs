using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControl : MonoBehaviour
{
    public List<GameObject> RoomInEnemyList = new List<GameObject>();
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player")) 
        {
            PlayerTargeting.EnemyList = new List<GameObject>(RoomInEnemyList);
        }
        else if(other.CompareTag("Enemy"))
        {
            RoomInEnemyList.Add(other.gameObject);
        }
    }
}
