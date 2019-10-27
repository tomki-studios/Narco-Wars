using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public SaveLoad saveLoad; //initializing savig and loading script
    public Text txt;

    void Update()
    {
        txt.text = VariableTag.cash.ToString(); 
    }
    //public void Debug() //debugging
    //{
    //    VariableTag.cash -= 100;
    //    saveLoad.Save();
    //}

}
//By Daniel "MiPiNi" Grala
