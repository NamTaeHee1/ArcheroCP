using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float h = 0;
    private float v = 0;
    [SerializeField] private float MoveSpeed = 6.0f;

    private Transform PlayerTransform;

    private Animator PlayerAnimator;

    private bool isMoving = false;

    private void Awake() 
    {
            PlayerTransform = GetComponent<Transform>();
            PlayerAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        GetAxis();
        PlayerRotate();
    }

    private void FixedUpdate() 
    {
        PlayerMove();
    }

    private void GetAxis() // 현재 조이스틱의 위치 값을 받아옴.
    {
        h = FindObjectOfType<JoyStickControl>().JoyStickVec.x;
        v = FindObjectOfType<JoyStickControl>().JoyStickVec.y;
        isMoving = (h != 0 || v != 0) ? true : false;
        PlayerAnimator.SetBool("isMoving", isMoving);
    }

    private void PlayerMove() // 조이스틱의 위치에 맞게 플레이어를 이동
    {
        if(isMoving)
            PlayerTransform.parent.transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * MoveSpeed);
    }

    private void PlayerRotate() // 조이스틱이 이동한 위치를 바라보게 회전
    {
        PlayerTransform.eulerAngles = new Vector3(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0);
    }
}
