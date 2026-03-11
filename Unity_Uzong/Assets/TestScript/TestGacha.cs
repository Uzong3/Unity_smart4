using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_Result;
    [SerializeField] Button btn_Gacha;

    [SerializeField] string[] S;
    [SerializeField] string[] A;
    [SerializeField] string[] B;
    [SerializeField] string[] C;

    private void Awake()
    {
        btn_Gacha.onClick.AddListener(GachaFunc);
    }

    private void Start()
    {
        GachaFunc();
    }

    void GachaFunc()
    {
        int randomValue = Random.Range(1, 101); // 랜덤한 값이 담길 변수를 선언합니다. 랜덤한 값의 범위를 설정하고 변수에 담아줍니다.

        if (randomValue <= 5) // 5% 확률
        {
            int index = Random.Range(0, S.Length);
            txt_Result.text = S[index];
        }
        else if (randomValue <= 20) // 15% 확률
        {
            int index = Random.Range(0, A.Length);
            txt_Result.text = A[index];
        }
        else if (randomValue <= 50) // 30% 확률
        {
            int index = Random.Range(0, B.Length);
            txt_Result.text = B[index];
        }
        else
        {
            int index = Random.Range(0, C.Length);
            txt_Result.text = C[index];
        }
    }
}
