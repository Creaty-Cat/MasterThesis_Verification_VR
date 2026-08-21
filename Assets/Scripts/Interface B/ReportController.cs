using UnityEngine;

public class ReportController : MonoBehaviour
{
    [SerializeField] private GameObject reportInterface;

    public void ReportUser()
    {
        reportInterface.SetActive(true);
    }
}
