using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadScene1()
    {
        LoadScene("Interface A");
    }

    public void LoadScene2()
    {
        LoadScene("Interface B");
    }

    public void LoadMainMenu()
    {
        LoadScene("Menu");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
