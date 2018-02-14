using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    private LevelManager levelManager;
    public int maxHits;
    private int timesHit;


	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;

        if (timesHit >= maxHits)
        {
            DestroyObject(gameObject);
        }


    }

    // TODO remove this method when we can actually win.
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

}
