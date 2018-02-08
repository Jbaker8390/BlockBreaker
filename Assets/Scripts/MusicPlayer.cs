using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

     void Awake()
    {
        //instanceiD of current gameobj
        Debug.Log("Music Player Awake " + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            print("Duplicate music player, self-destruct");
        }
        else
        {
            //claims the instance, it's the global instance - singleton pattern
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        Debug.Log("Music Player Start " + GetInstanceID());
       
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
