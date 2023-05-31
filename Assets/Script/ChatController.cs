using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChatController : MonoBehaviour
{
    public TextMeshProUGUI ChatText;
    public TextMeshProUGUI ChatName;
    private string writerText;

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        ChatName.text = narrator;
        writerText = "";

        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }
        
    }
    public IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("���", "�׷�.. ���������� �ϰ�ʹٰ�?"));
    }

    private void Start()
    {
        StartCoroutine(TextPractice());
    }
}
