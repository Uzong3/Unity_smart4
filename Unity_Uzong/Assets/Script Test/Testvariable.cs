using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testvariable : MonoBehaviour
{
    string name;
    float maxHP;
    float nowHP;


    private void Awake()
    {
        name = "메타몽";
        maxHP = 100;
    }

    private void OnEnable()
    {
        nowHP = maxHP;
        Debug.Log($"{name}의 현재 체력 : {nowHP} / {maxHP}");
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        nowHP -= 1 * Time.deltaTime;
        Debug.Log($"{name}의 현재 체력 : {nowHP} / {maxHP}");

        if (nowHP < 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        Debug.Log($"{name}이 힘이 다했다.");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy 호출 : 오브젝트가 삭제될 때");
    }
}
