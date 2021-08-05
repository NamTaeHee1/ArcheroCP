using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTargeting : MonoBehaviour
{
    private PlayerTargeting instance;
    public List<GameObject> EnemyList = new List<GameObject>();

        private void Update() {
            for(int i = 0 ; i < EnemyList.Count; i++)
                print(EnemyList[i].name);
        }
}
