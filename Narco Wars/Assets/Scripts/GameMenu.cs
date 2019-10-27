using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

    public GameObject PausePanel;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SwitchPausePanel();
        }
    }
	public void SwitchPausePanel()
    {
        if (PausePanel.activeInHierarchy)
        {
            PausePanel.SetActive(false);
        }
        else if (!PausePanel.activeInHierarchy)
        {
            PausePanel.SetActive(true);
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
