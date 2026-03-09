using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Awake()
    {
        // 가장먼저 실행
        // 최초 1회만 실행
        UnityEngine.Debug.Log("Awake 호출 : 가장먼저 1회 호출");

    }

    private void OnEnable()
    {
        UnityEngine.Debug.Log("OnEnable 호출 : 오브젝트가 활성화 될 때 호출");
    }

    void Start()
    {
        // Start is called before the first frame update
        // void : 반환하는 타입이 없다
        // Start : 함수의 이름
        // () : 전달하는 것도 없다
        UnityEngine.Debug.Log("Start 호출 : 1회 호출 안녕하세요");
    }

    private void Update()
    {
        // Update is called once per frame
        UnityEngine.Debug.Log("Update 호출 : 매번 실행");
    }

    private void OnDisable()
    {
        UnityEngine.Debug.Log("Ondisable 호출 : 오브젝트 비활성화 될 때 호출");
    }

    private void OnDestroy()
    {
        UnityEngine.Debug.Log("OnDestroy 호출 : 오브젝트 삭제될때 호출");
    }

}
