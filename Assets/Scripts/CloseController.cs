using UnityEngine;

public class CloseController : MonoBehaviour
{
    [SerializeField] private GameObject closeInterface;
    [SerializeField] private GameObject openInterface;

    public void Close(GameObject closeInterface)
    {
        closeInterface.SetActive(false);
    }

    public void Open(GameObject openInterface)
    {
        openInterface.SetActive(true);
    }
}
