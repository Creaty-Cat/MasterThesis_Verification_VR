using UnityEngine;

using UnityEngine.EventSystems;

public class HoverShowInterface : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject interfaceToShow;

    public void OnPointerEnter(PointerEventData eventData)
    {
        interfaceToShow.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        interfaceToShow.SetActive(false);
    }
}
