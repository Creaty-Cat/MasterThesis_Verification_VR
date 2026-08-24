using UnityEngine;

public class AvatarRing : MonoBehaviour
{
    public GameObject interfaceUI;
    public Renderer ringRenderer;

    [Header("Hover Colors")]
    public Color normalEmission = Color.white;
    public Color hoverEmission = Color.cyan;

    [Header("Brightness")]
    public float normalIntensity = 1f;
    public float hoverIntensity = 3f;
    
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

    public void HoverEnter()
    {
        ringRenderer.material.SetColor("_EmissionColor", hoverEmission * hoverIntensity);
    }

    public void HoverExit()
    {
        ringRenderer.material.SetColor("_EmissionColor", normalEmission * normalIntensity);
    }
}
