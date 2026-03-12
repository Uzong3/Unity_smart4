using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript04 : MonoBehaviour
{

    void Hello()
    {
        int Saying;
        int allStudent = 5;
        for (Saying = 1; Saying <= allStudent; Saying++)
        {
            Debug.Log($"안녕?");
        }


    }

    [SerializeField] int S_Tier;
    [SerializeField] int A_Tier;
    [SerializeField] int B_Tier;
    [SerializeField] int C_Tier;

    private void Start()
    {
        int i = 0;
        while (i < 10)
        {
            GachaSwitch();
            i++;

            if(i >=  10)
            {
                break;
            }
        }

    }
    private void For()
    {
        for(int i = 1; i <= 10;  i++)
        {
            GachaSwitch();
        }
        
    }
    private void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101);

        switch (randomValue)
        {
            case <= 5:

                int random = Random.Range(0, 2);
                if (random == 0)
                {
                    S_Tier++;
                    Debug.Log($"S 등급 : {S_Tier}");
                }
                else
                {
                    S_Tier++;
                    Debug.Log($"픽업 S 등급 당첨! : {S_Tier}");
                }
                break;

            case <= 20:
                A_Tier++;
                Debug.Log($"A 등급 : {A_Tier}");
                break;

            case <= 50:
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
