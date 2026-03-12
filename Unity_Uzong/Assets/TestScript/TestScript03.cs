using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TestScript03 : MonoBehaviour
{
    [SerializeField] int myGold;
    [SerializeField] int redPotion;
    [SerializeField] int yellowPotion;
    [SerializeField] int bluePotion;

    private void PotionSwitch()
    {
        string wish = "노란 포션"; // 내가 원하는 포션

        switch (wish)              // 선택한 포션
        {
            case "빨간 포션":      // 빨간 포션 구매 시
                myGold -= 150;
                redPotion++;
                break;

            case "노란 포션":      // 노란 포션 구매 시
                myGold -= 200;
                yellowPotion++;
                break;

            case "파란 포션":      // 파란 포션 구매 시
                myGold -= 350;
                bluePotion++;
                break;
        }
        Debug.Log($"남은 골드 : {myGold} / R : {redPotion} / Y : {yellowPotion} / B : {bluePotion}");

    }


    [SerializeField] int S_Tier;
    [SerializeField] int A_Tier;
    [SerializeField] int B_Tier;
    [SerializeField] int C_Tier;

    private void GachaIf()
    {
        int randomValue = Random.Range(1, 101);
        if (randomValue <= 5) // 5% 확률
        {
            Debug.Log("S등급");
            int random = Random.Range(0, 2);
            if (random == 0)
            {
                S_Tier++;
                Debug.Log("S등급");
            }
            else
            {
                S_Tier++;
                Debug.Log("픽업 S등급");
            }
        }
        else if (randomValue <= 20) // 15% 확률
        {
            A_Tier++;
            Debug.Log("A등급");
        }
        else if (randomValue <= 50) // 30% 확률
        {
            B_Tier++;
            Debug.Log("B등급");
        }
        else // 50% 확률
        {
            C_Tier++;
            Debug.Log("C등급");
        }

        Debug.Log($"S등급 : {S_Tier} / A등급 : {A_Tier} / B등급 : {B_Tier} / C등급 : {C_Tier}");
    }

    private void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101);
        
        switch (randomValue)
        {
            case <= 5 :
                S_Tier++;
                Debug.Log($"S 등급 : {S_Tier}");
                break;

            case <= 20 :
                A_Tier++;
                Debug.Log($"A 등급 : {A_Tier}");
                break;

            case <= 50 :
                B_Tier++;
                Debug.Log($"B 등급 : {B_Tier}");
                break;

            case <= 100:
                C_Tier++;
                Debug.Log($"C 등급 : {C_Tier}");
                break;
        }
        Debug.Log($"S등급 : {S_Tier} / A등급 : {A_Tier} / B등급 : {B_Tier} / C등급 : {C_Tier}");
    }

}
