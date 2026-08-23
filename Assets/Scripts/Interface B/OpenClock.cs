using UnityEngine;

public class OpenClock : MonoBehaviour
{
    [SerializeField] private GameObject interface1;
    [SerializeField] private GameObject interface2;

    public void OpenInterfaces()
    {
        interface1.SetActive(true);
        interface2.SetActive(true);
    }

    public void CloseInterfaces()
    {
        interface1.SetActive(false);
        interface2.SetActive(false);
    }
}

