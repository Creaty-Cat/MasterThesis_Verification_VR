using UnityEngine;

public class ToggleInterface : MonoBehaviour
{
    public void Toggle(GameObject interfaceObject)
    {
        interfaceObject.SetActive(!interfaceObject.activeSelf);
    }

}
