using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AvatarDialogue : MonoBehaviour
{
	public DialogueStep[] dialogue;

	public GameObject dialogueBox;
	public GameObject speechBubble;
	public GameObject popup;

	public TMP_Text avatarText;
	public TMP_Text popupText;

	public Button[] optionButtons;
	public Button closePopup;



	private int currentStep = 0;

	public void StartNPCDialogue(){

		//set speechBubble invisible
		speechBubble.SetActive(false);
		//set dialogueBox visible
		dialogueBox.SetActive(true);

		//zur Sicherheit ausblenden
		popup.SetActive(false);

		currentStep = 0;

		ShowDialogue();
	}

	void ShowDialogue()
	{
		//Get the currently active dialogue entry
		DialogueStep step = dialogue[currentStep];

		//display avatar text
		avatarText.text = step.avatarText;

		for (int i = 0; i < optionButtons.Length; i++)
		{
			if(i < step.userOptions.Length)
			{
				optionButtons[i].gameObject.SetActive(true);

				//Set the button text to the user option
				optionButtons[i].GetComponentInChildren<TMP_Text>().text = step.userOptions[i].text;

				//Button click event to corresponding option
				optionButtons[i].onClick.RemoveAllListeners();

				int optionIndex = i;

				//Hide unused buttons
				optionButtons[i].onClick.AddListener(
					() => SelectionOption(optionIndex)
				);
			}
			else
			{
				optionButtons[i].gameObject.SetActive(false);
			}
		}
	}

	void SelectionOption(int optionIndex)
	{
		//Retrieve selected option from the current dialogue step
		DialogueOption selectedOption = dialogue[currentStep].userOptions[optionIndex];

		if(selectedOption.openPopup)
		{
			ShowPopup(selectedOption.popupText);
		}
		else
		{
			NextDialogue();
		}
	}

	//popup window with additional info
	void ShowPopup(string text)
	{
		popup.SetActive(true);

		popupText.text = text;

		closePopup.onClick.RemoveAllListeners();
		closePopup.onClick.AddListener(ClosePopup);
	}

	void ClosePopup()
	{
		popup.SetActive(false);

		NextDialogue();
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
