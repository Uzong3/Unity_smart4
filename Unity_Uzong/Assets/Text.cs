using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_Dialogue;
    [SerializeField] float typingSpeed = 0.05f;
    Coroutine typingCoroutine;

    [SerializeField] Button btn_Text;

    private void Awake()
    {
        btn_Text.onClick.AddListener(TypingEffect);
    }

    void TypingEffect()
    {
        txt_Dialogue.text = "디벨로켓 화이팅 함께 가자 디벨로켓 큐알코드찍어주세요 주말엔 주무세요";

        if (typingCoroutine != null) StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypingCoroutine());
    }

    IEnumerator TypingCoroutine()
    {
        int totalTextLength = txt_Dialogue.text.Length;
        txt_Dialogue.maxVisibleCharacters = 0;

        for (int i = 0; i <= totalTextLength; i++)
        {
            txt_Dialogue.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public float shakeMagnitude = 2f; // 흔들림 강도

    void Update()
    {
        txt_Dialogue.ForceMeshUpdate();
        var textInfo = txt_Dialogue.textInfo;

        for (int i = 0; i < textInfo.characterCount; i++)
        {
            var charInfo = textInfo.characterInfo[i];

            // 보이지 않는 문자는 스킵
            if (!charInfo.isVisible) continue;

            var verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

            // 각 글자의 4개 정점에 랜덤 오프셋 적용
            Vector3 offset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0) * shakeMagnitude;

            for (int j = 0; j < 4; j++)
            {
                verts[charInfo.vertexIndex + j] += offset;
            }
        }

        // 변경된 정점 데이터를 메시에 적용
        for (int i = 0; i < textInfo.meshInfo.Length; i++)
        {
            textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;
            txt_Dialogue.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
        }
    }
}
