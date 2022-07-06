using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {

    [Header("Menu & Next Level")]
    public string menuSceneName = "MainMenu";

    public string nextLevel = "Level02";

    [Header("Scene Fader")]
    public bool useSceneFader = true;

    public SceneFader sceneFader;

    [Header("Level To Unlock")]
    public bool useLevelToUnlock = true;

    public int levelToUnlock = 2;

    public void Continue ()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }

    public void Menu ()
    {
        sceneFader.FadeTo(menuSceneName);
    }

}
