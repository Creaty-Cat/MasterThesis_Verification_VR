using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GameObject interfaceToClose;
    [SerializeField] private GameObject avatar;

    public void BlockUser()
    {
        interfaceToClose.SetActive(false);
        avatar.SetActive(false);
    }
}
