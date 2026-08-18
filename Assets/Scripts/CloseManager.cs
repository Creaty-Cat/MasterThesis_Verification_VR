using UnityEngine;

public class CloseManager : MonoBehaviour
{
    public void CloseInterface(GameObject panel)
    {
        panel.SetActive(false);
    }
}
