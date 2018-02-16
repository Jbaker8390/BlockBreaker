using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {
  
    public void LoadLevel(string name)
    {
        Debug.Log("Lvel load requested for : " + name);
        //Loads the particular level
        SceneManager.LoadScene(name);
    }
		
    public void QuitRequest()
    {
        Debug.Log("I want to quit!");
        Application.Quit();
    }

    public void ReturnToStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	}
