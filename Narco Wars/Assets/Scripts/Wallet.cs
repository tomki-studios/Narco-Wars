using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public SaveLoad saveLoad; //initializing savig and loading script
    public int cash = 100000; //starting cash
    public Text txt; //debugging

    // Update is called once per frame
    void Update()
    {
        txt.text = cash.ToString(); //debbuging
    }
    public void Debug() //only debugging
    {
        cash -= 100;
        saveLoad.Save();
    }
}
//By Daniel "MiPiNi" Grala
