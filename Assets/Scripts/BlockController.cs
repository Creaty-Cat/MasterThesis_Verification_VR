using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GameObject interfaceToClose;
    [SerializeField] private GameObject blockInformation;
    [SerializeField] private GameObject avatar;
    [SerializeField] private GameObject badge;
    [SerializeField] private GameObject blockInterface1;

    [SerializeField] private OpenClock openClock;

    public enum InterfaceToBlock
    {
        Interface1,
        Interface2,
        Both
    }

    [SerializeField] private InterfaceToBlock interfaceToBlock;

    public void BlockUser()
    {
        blockInformation.SetActive(true);
        interfaceToClose.SetActive(false);
        avatar.SetActive(false);
        badge.SetActive(false);
        blockInterface1.SetActive(false);

        if (interfaceToBlock == InterfaceToBlock.Interface1)
        {
            openClock.BlockInterface1();
        }
        else if (interfaceToBlock == InterfaceToBlock.Interface2)
        {
            openClock.BlockInterface2();
        }
        else if (interfaceToBlock == InterfaceToBlock.Both)
        {
            openClock.BlockBothInterfaces();
        }
    }
}
