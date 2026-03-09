using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestInt : MonoBehaviour
{
    int number = 0;
    float number2 = 0.5f;

    string munza = "안녕하세요";

    bool truefalse = true;
    bool truefalse2 = false;

    // 참쉽죠


    int playerinventorysize; // player + inventory + size
    int playerInventorySize;
    int player_inventory_size;

    // 대소문자 + _언더바 구분가능


    public int publicInt;
    private int privateInt;

    public TextMeshProUGUI textMeshProUGUI;

    public void OnClick()
    {
        textMeshProUGUI.text = Random.Range(0, publicInt).ToString();
    }

    // 스크립트 컴포넌트 추가하기
}
