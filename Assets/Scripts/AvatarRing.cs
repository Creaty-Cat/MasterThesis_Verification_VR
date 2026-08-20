using UnityEngine;

public class AvatarRing : MonoBehaviour
{
    public GameObject interfaceUI;
    
    public void OpenInterface()
    {
        Debug.Log("RING ANGEKLICKT");
        interfaceUI.SetActive(true);
        
    }

    
    public void CloseInterface()
    {
        interfaceUI.SetActive(false);
    }
}
