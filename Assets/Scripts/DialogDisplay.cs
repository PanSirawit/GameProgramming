using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogDisplay : MonoBehaviour
{
    [SerializeField] private DialogBlueprint activechat;
    [SerializeField] private TMP_Text dialogDisplay;
    [SerializeField, Range(0,1)] private float TextSpeed;
    private int line;

    private void Start()
    {
        StartChat();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChatInteraction();
        }
    }
    void StartChat()
    {
        line = 0;
        StartCoroutine(TypeLine());
    }

    void NextLine()
    {
        line += 1;

        if (line < activechat.dialogues.Length)
            StartCoroutine(TypeLine());
    }

    void ChatInteraction()
    {
        if (line == activechat.dialogues.Length - 1 && dialogDisplay.text == activechat.dialogues[line].message)ConversationEnd();
        else if(dialogDisplay.text == activechat.dialogues[line].message) NextLine();
        else
        {
            StopAllCoroutines();
            dialogDisplay.text = activechat.dialogues[line].message;
        }
    }
    void ConversationEnd()
    {
        Debug.Log("EndOfConversation");
    }
    IEnumerator TypeLine()
    {
        dialogDisplay.text = string.Empty;
        foreach(char c in activechat.dialogues[line].message)
        {
            dialogDisplay.text += c;
            yield return new WaitForSeconds(TextSpeed); 
        }
    }
}
