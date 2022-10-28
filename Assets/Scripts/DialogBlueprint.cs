using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialog/Blueprint")]
public class DialogBlueprint : ScriptableObject
{
    public DialogDetail[] dialogues;
}
[System.Serializable]
public class DialogDetail
{
    public string speakerName;
    [TextArea(10,10)]public string message;
}