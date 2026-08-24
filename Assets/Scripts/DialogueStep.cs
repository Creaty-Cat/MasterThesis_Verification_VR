using UnityEngine;

[System.Serializable]
public class DialogueOption
{
    public string text;

    //soll Popup angezeigt werden?
    public bool openPopup;

    //Text der angezeigt wird
    [TextArea(3,8)]
    public string popupText;
}


[System.Serializable]
public class DialogueStep
{
    [TextArea(3, 8)]
    public string avatarText;

    public DialogueOption[] userOptions;
    
}
