using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript01 : MonoBehaviour
{
    // 1. 내 골드가 담길 변수를 선언
    // 2. 포션이 저장될 변수를 선언
    // 3. Start 함수에 조건문을 사용하여, 
    //      내 골드가 200원 이상이면
    //      200원을 소모하여 포션을 1증가시키는 식 작성
    // 4. 나의 남은 골드와 남은 포션의 수량을 출력(Debug.Log() 사용)

    // C#에서는 앞에 안붙히면 자동 private 판단
    // [SerializaField] 사용하면 Inspector 창에서 수치변경 가능
    // 따라서 개발자에게는 inspector 창에서 조절 가능하게끔 해달라고 해야함
    // public으로 해도 가능하지만 그건 적절한 개발방식이 아님

    [SerializeField] int myGold; 
    [SerializeField] int myPotion; 

    private void Update()
    {
        if (myGold >= 200) // 200원 이상 있을 경우에 1 포션 구입
        {
            myGold -= 200;
            myPotion++;
        }
        else if (myGold >= 100) // 200원도 없을 경우에 100원 지불 후 1 포션 구입
        {
            myGold -= 100;
            myPotion++;
        }
        else // 100원도 없을 경우에 상점주인 분노
        {
            Angry();
        }
        Debug.Log(myGold);
        Debug.Log(myPotion);

        Debug.Log($"소지 골드 : {myGold} / 소지 포션 : {myPotion}");

        Debug.Log("남은 골드 : " + myGold + "/ 소지한 포션 : " + myPotion); // 가장 적절한 방법

        void Angry()
        {
            Debug.Log("상점주인 : 그럼 죽어");
        }

    }

}
