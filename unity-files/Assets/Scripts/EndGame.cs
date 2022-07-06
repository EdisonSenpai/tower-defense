using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public string menuSceneName = "MainMenu";

    public SceneFader sceneFader;

    public void Quit ()
    {
        Debug.Log("Exciting...");

        Application.Quit();
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }

}
