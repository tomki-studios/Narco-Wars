using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public SaveLoad saveLoad; //initializing savig and loading script
    public Text txt;
    void Start()
    {
        new_game(VariableTag.new_game);
    }
    void Update()
    {
        txt.text = VariableTag.cash.ToString();
    }
    private void new_game(bool new_game)
    {
        if (new_game == true)
        {
            VariableTag.cash = 10000f;
        }
        else { saveLoad.Load(); }
    }
    //public void Debug() //debugging
    //{
    //    VariableTag.cash -= 100;
    //    saveLoad.Save();
    //}

}
//By Daniel "MiPiNi" Grala
