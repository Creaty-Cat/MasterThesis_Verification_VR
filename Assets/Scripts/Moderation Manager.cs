using UnityEngine;
using UnityEngine.UI;

public class ModerationManager : MonoBehaviour
{
    public GameObject BlockInterface;
    public GameObject ReportInterface;
    public GameObject Verification1;
    public GameObject Verification1_Unfolded;

    public void ReportUser()
    {
        ReportInterface.SetActive(true);
    }

    public void BlockUser()
    {
        BlockInterface.SetActive(true);
        Verification1.SetActive(false);
        Verification1_Unfolded.SetActive(false);
    }
}
