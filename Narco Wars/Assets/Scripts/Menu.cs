using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public SaveLoad saveLoad;
    public GameObject SettingsPanel;
    public GameObject MenuPanel;

	public void Play()
    {
        saveLoad.Load();
        MenuPanel.SetActive(false);
        SceneManager.LoadScene("Gra"); //w tej scenie trzeba sprawdzic czy to pierwsze uruchomienie, jesli tak to panel tworzenia wytwrni a jak nie to kontynuacja gry
    }

    public void SwitchSettingsPanel()
    {
        if (MenuPanel.activeInHierarchy)
        {
            MenuPanel.SetActive(false);
            SettingsPanel.SetActive(true);
        }
        else if (!MenuPanel.activeInHierarchy)
        {
            MenuPanel.SetActive(true);
            SettingsPanel.SetActive(false);
        }
    }
}
