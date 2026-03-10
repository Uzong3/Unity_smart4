using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript03 : MonoBehaviour
{
    int myGold;
    int redPotion;
    int yellowPotion;
    int bluePotion;

    private void Gacha()
    {
        string wish = "노란 포션";       // 내가 원하는 포션

        switch (wish)                   // 선택한 포션
        {
            case "빨간 포션":            // 빨간 포션 상황
                myGold -= 200;          // 200 골드를 지불합니다.    
                redPotion++;            // 빨간 포션을 구매합니다.
                break;                  // switch 문을 종료합니다.

            case "노란 포션":            // 노란 포션 상황
                myGold -= 150;          // 150 골드를 지불합니다.    
                yellowPotion++;         // 노란 포션을 구매합니다.
                break;                  // switch 문을 종료합니다.

            case "파란 포션":            // 파란 포션 상황
                myGold -= 300;          // 300 골드를 지불합니다.    
                bluePotion++;           // 파란 포션을 구매합니다.
                break;                  // switch 문을 종료합니다.

            default:                    // 어떠한 상황도 맞지 않을 때, 동작하는 기본값입니다.
                break;
        }
        
        Debug.Log($"남은 골드 : {myGold} / R : {redPotion} / Y : {yellowPotion} / B : {bluePotion}");

    }


}
