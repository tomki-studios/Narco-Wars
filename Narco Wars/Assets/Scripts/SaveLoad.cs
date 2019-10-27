﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    void Awake()
    {
        Load(); //loading all variables on awake
    }
    public void Save() //saving variables to memory
    {
        PlayerPrefs.SetFloat("cash", VariableTag.cash);
    }
    public void Load() //loading variables from memory and setting them to specified variable
    {
        if (PlayerPrefs.HasKey("cash")) //if any variable is already saved, load all
        {
            VariableTag.cash = PlayerPrefs.GetFloat("cash");
        }
        else //else save all
            Save();
    }
}
//By Daniel "MiPiNi" Grala
