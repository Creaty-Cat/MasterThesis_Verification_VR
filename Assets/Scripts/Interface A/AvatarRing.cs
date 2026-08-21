using UnityEngine;

public class AvatarRing : MonoBehaviour
{
    public GameObject interfaceUI;
    
    public void ToggleInterface()
    {
        //Interface kann mit dem Ring Objekt aus und angeschaltet werden
        if(interfaceUI.activeSelf)
        {
            
            interfaceUI.SetActive(false);
        }
        else
        {
            Debug.Log("RING ANGEKLICKT");
            interfaceUI.SetActive(true);
        }
        
    }

    
    public void CloseInterface()
    {
        interfaceUI.SetActive(false);
    }
}
