using UnityEngine;

public class CloseController : MonoBehaviour
{
    [SerializeField] private GameObject closeInterface;

    public void Close()
    {
        closeInterface.SetActive(false);
    }
}
