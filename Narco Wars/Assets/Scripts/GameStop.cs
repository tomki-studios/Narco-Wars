using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStop : MonoBehaviour {

    public Canvas Stop;
    

	public void Pause()
    {
        Stop.enabled = true;
    }

    public void Unpause()
    {
        Stop.enabled = false;
    }
}
