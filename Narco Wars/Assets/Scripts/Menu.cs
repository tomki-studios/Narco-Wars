using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public SaveLoad saveLoad;
    public GameObject SettingsPanel;
    public GameObject MenuPanel;
    public GameObject ChoosePanel;
    public GameObject New_Load_Game;

    public void Play()
    {
        MenuPanel.SetActive(false);
        New_Load_Game.SetActive(true);
    }
    public void New_Game()
    {
        New_Load_Game.SetActive(false);
        ChoosePanel.SetActive(true);
    }
    public void Load_Game()
    {
        saveLoad.Load();
        SceneManager.LoadScene("Gra");
    }
    public void Return()
    {
        if (SettingsPanel.activeInHierarchy)
        {
            SettingsPanel.SetActive(false);
            MenuPanel.SetActive(true);
        }
        else if (New_Load_Game.activeInHierarchy)
        {
            New_Load_Game.SetActive(false);
            MenuPanel.SetActive(true);
        }
        else if (ChoosePanel.activeInHierarchy)
        {
            ChoosePanel.SetActive(false);
            New_Load_Game.SetActive(true);
        }
    }
    public void Options_click()
    {
        MenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }

    /*public void SwitchSettingsPanel()
    {
        if (MenuPanel.activeInHierarchy)
        {
            MenuPanel.SetActive(false);
            SettingsPanel.SetActive(true);
            ChoosePanel.SetActive(false);
        }
        else if (!MenuPanel.activeInHierarchy)
        {
            MenuPanel.SetActive(true);
            SettingsPanel.SetActive(false);
            ChoosePanel.SetActive(false);
        }
      
    }*/
}
