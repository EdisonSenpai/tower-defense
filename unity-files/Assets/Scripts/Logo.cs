using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour
{

    public string loadingScene = "MainMenu";

    public SceneFader sceneFader;

    public void Click ()
    {
        sceneFader.FadeTo(loadingScene);
    }
}
