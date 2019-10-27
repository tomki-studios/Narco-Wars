using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public int Game;
    public Canvas Opitons;
    public Canvas Menu1;
    public Canvas Chose;

	public void Play()
    {
        Menu1.enabled = false;
        Chose.enabled = true;
    }

    public void LoadGame()
    {
        //Na razie puste bo nie umiem zrobić//
    }

    public void NewGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: Game);
    }

    public void Settings()
    {
        Menu1.enabled = false;
        Opitons.enabled = true;
    }

    public void Back()
    {
        Menu1.enabled = true;
        Opitons.enabled = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
