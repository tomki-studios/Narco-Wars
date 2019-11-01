using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

    public GameObject PausePanel;
    public GameObject GamePanel;
    public GameObject WarehousePanel;
    
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
    public void WarehouseClick()
    {
        GamePanel.SetActive(false);
        WarehousePanel.SetActive(true);
    }
    public void Return()
    {
        WarehousePanel.SetActive(false);
        GamePanel.SetActive(true);
    }

}
