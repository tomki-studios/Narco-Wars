﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

    public int Menu;

    public void Back()
    {
        SceneManager.LoadScene(sceneBuildIndex: Menu);
    }

}
