using UnityEngine;


[System.Serializable]
public class DialogueStep
{
    [TextArea(3, 8)]
    public string avatarText;

    public string[] userOptions;
    
}
