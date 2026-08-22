using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GameObject interfaceToClose;
    [SerializeField] private GameObject blockInformation;
    [SerializeField] private GameObject avatar;

    public void BlockUser()
    {
        blockInformation.SetActive(true);
        interfaceToClose.SetActive(false);
        avatar.SetActive(false);
        
    }
}
