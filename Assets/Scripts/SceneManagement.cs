using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadInterfaceA()
    {
        Debug.Log("LoadInterfaceA wurde aufgerufen!");
        SceneManager.LoadScene("InterfaceA");
    }

    public void LoadInterfaceB()
    {
        Debug.Log("LoadInterfaceB wurde aufgerufen!");
        SceneManager.LoadScene("InterfaceB");
    }

    public void QuitApplication()
    {
        Debug.Log("QuitApplication wurde aufgerufen!");
        Application.Quit();
    }
}
