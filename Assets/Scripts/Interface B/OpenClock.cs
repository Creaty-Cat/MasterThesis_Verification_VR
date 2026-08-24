using UnityEngine;

public class OpenClock : MonoBehaviour
{
    [SerializeField] private GameObject interface1;
    [SerializeField] private GameObject interface2;

    // Jeder Status wird unabhängig gespeichert
    private bool interface1Blocked = false;
    private bool interface2Blocked = false;

    public void OpenInterfaces()
    {
        if (!interface1Blocked)
        {
            interface1.SetActive(true);
        }

        if (!interface2Blocked)
        {
            interface2.SetActive(true);
        }
    }

    public void CloseInterfaces()
    {
        interface1.SetActive(false);
        interface2.SetActive(false);
    }

    public void BlockInterface1()
    {
        interface1Blocked = true;
        interface1.SetActive(false);
    }

    public void BlockInterface2()
    {
        interface2Blocked = true;
        interface2.SetActive(false);
    }

    public void BlockBothInterfaces()
    {
        interface1Blocked = true;
        interface2Blocked = true;

        interface1.SetActive(false);
        interface2.SetActive(false);
    }
}

