using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Animator anicon;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 입력
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // 이동
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // 회전
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 20f);
        }

        // 애니메이터
        bool isWalk = 0 < moveDirection.magnitude;
        anicon.SetBool("isWalk", isWalk);
    }
}
