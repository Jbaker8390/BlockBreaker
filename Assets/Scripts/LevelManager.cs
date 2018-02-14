using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
  
    public void LoadLevel(string name)
    {
        Debug.Log("Lvel load requested for : " + name);
        //Loads the particular level
        Application.LoadLevel(name);
    }
		
    public void QuitRequest()
    {
        Debug.Log("I want to quit!");
        Application.Quit();
    }

    public void ReturnToStart()
    {
        Application.LoadLevel("Start");
    }
	}
