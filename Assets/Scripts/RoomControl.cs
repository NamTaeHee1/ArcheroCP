using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControl : MonoBehaviour
{
    public static List<GameObject> EnemyList = new List<GameObject>();
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Enemy"))
    }
}
