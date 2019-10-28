using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public SaveLoad saveLoad;
    public GameObject SettingsPanel;
    public GameObject MenuPanel;
    public GameObject ChoosePanel;

	public void Play()
    {
        saveLoad.Load();
        MenuPanel.SetActive(false);
        ChoosePanel.SetActive(true);
        //SceneManager.LoadScene("Gra"); //w tej scenie trzeba sprawdzic czy to pierwsze uruchomienie, jesli tak to panel tworzenia wytwrni a jak nie to kontynuacja gry
    }

    public void SwitchSettingsPanel()
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
      
    }
}
