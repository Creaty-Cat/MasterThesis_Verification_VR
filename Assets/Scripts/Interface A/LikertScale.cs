using UnityEngine;
using UnityEngine.UI;

public class LikertScale : MonoBehaviour
{
    public Button[] options;
    public GameObject[] crosses;

    private int selectedOption = -1;

    void Start()
    {
        // Alle X am Anfang ausblenden
        for (int i = 0; i < crosses.Length; i++)
        {
            crosses[i].SetActive(false);
        }

        // Buttons mit den Optionen verbinden
        for (int i = 0; i < options.Length; i++)
        {
            int index = i;

            options[i].onClick.AddListener(
                () => SelectOption(index)
            );
        }
    }

    void SelectOption(int index)
    {
        // Alle X ausblenden
        for (int i = 0; i < crosses.Length; i++)
        {
            crosses[i].SetActive(false);
        }

        // X bei der ausgewählten Option anzeigen
        crosses[index].SetActive(true);

        // Auswahl speichern
        selectedOption = index;
    }
}
