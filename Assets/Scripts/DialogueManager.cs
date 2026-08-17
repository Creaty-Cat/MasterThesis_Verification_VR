using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public Button[] optionButtons;
    public DialogueStep[] dialogueSteps;
    private int currentStep = 0;

    void Start(){
        ShowCurrentStep();
    }

    void ShowCurrentStep(){
        DialogueStep step = dialogueSteps[currentStep];
        dialogueText.text = step.avatarText;

        for (int i = 0; i < optionButtons.Length; i++){
            if (i < step.userOptions.Length){
                optionButtons[i].gameObject.SetActive(true);

                optionButtons[i].GetComponentInChildren <TMP_Text>().text = step.userOptions[i];
                optionButtons[i].onClick.RemoveAllListeners();
                optionButtons[i].onClick.AddListener(NextDialogue);
            }
            else{
                optionButtons[i].gameObject.SetActive(false);
            }
        }
    }

    void NextDialogue(){
        currentStep++;
        if(currentStep < dialogueSteps.Length){
            ShowCurrentStep();
        }
    }

    
}
