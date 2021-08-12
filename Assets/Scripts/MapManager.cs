using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public class StartPositionArray
    {
        public List<Transform> StartPosition = new List<Transform>();
    }
    public StartPositionArray[] StartPositions; // 스테이지를 이동할 때 시작하는 위치를 저장할 배열

    public int CurrentStage = 0; // 현재 방 위치
    int LastStage = 10;

    public void NextStage()
    {
        CurrentStage++;
        if(CurrentStage > LastStage)
            return;

        int ArrayIndex = CurrentStage / 10;
        int RandomIndex = Random.Range(0, StartPositions[ArrayIndex].StartPosition.Count);
        transform.position = StartPositions[ArrayIndex].StartPosition[RandomIndex].position;
        StartPositions[ArrayIndex].StartPosition.RemoveAt(RandomIndex);
    }


    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
            FindObjectOfType<MapManager>().NextStage();
    }
}
