using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GameObject interfaceToClose;
    [SerializeField] private GameObject blockInformation;
    [SerializeField] private GameObject avatar;
    [SerializeField] private GameObject badge;
    [SerializeField] private GameObject blockInterface1;



    public void BlockUser()
    {
        blockInformation.SetActive(true);
        interfaceToClose.SetActive(false);
        avatar.SetActive(false);
        badge.SetActive(false);
        blockInterface1.SetActive(false);
        
    }
}
