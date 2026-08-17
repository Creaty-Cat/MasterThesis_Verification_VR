using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AvatarDialogue : MonoBehaviour
{
	public DialogueStep[] dialogue;

	public GameObject dialogueBox;

	public GameObject speechBubble;

	public TMP_Text avatarText;

	public Button[] optionButtons;

	private int currentStep = 0;

	public void StartNPCDialogue(){

		//set speechBubble invisible
		speechBubble.SetActive(false);
		//set dialogueBox visible
		dialogueBox.SetActive(true);
		currentStep = 0;
		ShowDialogue();
	}

	void ShowDialogue(){
		DialogueStep step = dialogue[currentStep];

		avatarText.text = step.avatarText;

		for (int i = 0; i < optionButtons.Length; i++){
			if(i < step.userOptions.Length){
				optionButtons[i].gameObject.SetActive(true);

				optionButtons[i].GetComponentInChildren<TMP_Text>().text = step.userOptions[i];

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

		if(currentStep < dialogue.Length){
			ShowDialogue();
		}
		else{
			dialogueBox.SetActive(false);
		}
	}
}
