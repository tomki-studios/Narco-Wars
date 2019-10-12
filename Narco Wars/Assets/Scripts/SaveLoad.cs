using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Wallet wallet; //initializing class with cash variable
    void Awake()
    {
        Load(); //loading all variables on awake
    }
    public void Save() //saving variables to memory
    {
        PlayerPrefs.SetInt("cash", wallet.cash);
    }
    public void Load() //loading variables from memory and setting them to specified variable
    {
        if (PlayerPrefs.HasKey("cash")) //if any variable is already saved, load all
        {
            wallet.cash = PlayerPrefs.GetInt("cash");
        }
        else //else save all
            Save();
    }
}
//By Daniel "MiPiNi" Grala
