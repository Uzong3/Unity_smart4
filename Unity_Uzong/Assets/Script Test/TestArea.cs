using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestArea : MonoBehaviour
{
    int gold = 0; // 거실에 0원이 들어있는 공용 금고를 둠!

    void Player()
    {
        int level = 100; // 플레이어 방에서만 쓰는 개인 상자
        gold = gold + 100; // 거실로 나가서 공용 금고에 100 골드를 저금한다!
    }

    void Monster()
    {
        int level = 100; // 몬스터 방에서만 쓰는 개인 상자 (위랑 이름만 같지 아예 다름!)
        gold = gold - 50; // 몬스터가 거실로 나와서 공용 금고에서 50 골드를 훔쳐간다!
    }

    void Update()
    {
        Player();  // 매 프레임 100원을 더해!
        Monster(); // 매 프레임 50원을 빼! 
    }
}