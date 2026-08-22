using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GameObject interfaceToClose;
    [SerializeField] private GameObject blockInformation;
    [SerializeField] private GameObject avatar;
    [SerializeField] private GameObject badge;


    public void BlockUser()
    {
        blockInformation.SetActive(true);
        interfaceToClose.SetActive(false);
        avatar.SetActive(false);
        badge.SetActive(false);
        
    }
}
