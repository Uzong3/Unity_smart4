using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TestScript02 : MonoBehaviour
{
    [SerializeField] int randomValue = Random.Range(1, 101);

    [SerializeField] int myGold;
    [SerializeField] int S_Tier;
    [SerializeField] int A_Tier;
    [SerializeField] int B_Tier;
    [SerializeField] int C_Tier;

    // - Random.Range를 사용하여 랜덤값을 만들고 if문을 사용하여 만들어 봅시다.

    // 만약
    // - 5%의 확률로 S 등급
    //      (심화) S등급 가운데 픽업 캐릭터는 50% 확률도 등장합니다.
    // - 15%의 확률로 A 등급
    // - 30%의 확률로 B 등급
    // - 50%의 확률로 C 등급
    // - 뽑기 결과는 Console창에 출력될 수 있도록 로그를 통해 나타냅시다.

    // 랜덤한 값이 담길 변수를 선언합니다.
    // 랜덤한 값의 범위를 설정하고 변수에 담아줍니다.

    private void Start()
    {
        if (randomValue <= 5) // 5% 확률
        {
            Debug.Log("S등급");
            int random = Random.Range(0, 2);
            if (random == 0) 
            {
                Debug.Log("S등급");
            }
            else
            {
                Debug.Log("픽업 S등급");
            }
        }
        else if (randomValue <= 20) // 15% 확률
        {
            Debug.Log("A등급");
        }
        else if (randomValue <= 50) // 30% 확률
        {
            Debug.Log("B등급");
        }
        else // 50% 확률
        {
            Debug.Log("C등급");
        }
     
            Debug.Log($"S등급 : {S_Tier} / A등급 : {A_Tier} / B등급 : {B_Tier} / C등급 : {C_Tier}");
    }
}
