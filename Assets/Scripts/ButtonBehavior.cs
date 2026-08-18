using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    public Button unfoldButton;
    public Button unfoldButtonBack;
    public GameObject Verification1;
    public GameObject Verification1_Unfolded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ButtonVerificationReasons()
    {
        Verification1.SetActive(false);
        Verification1_Unfolded.SetActive(true);

    }

    public void ButtonVerificationReasonsRefold()
    {
        Verification1_Unfolded.SetActive(false);
        Verification1.SetActive(true);
    }

    // Update is called once per frame
    void Start()
    {
        unfoldButton.onClick.AddListener(ButtonVerificationReasons);
        unfoldButtonBack.onClick.AddListener(ButtonVerificationReasonsRefold);
    }
}
