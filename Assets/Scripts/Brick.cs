using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    //bring in multiple sprites
    public Sprite[] hitSprites;

    private int timesHit;
    private LevelManager levelManager;
    private bool isBreakable;
    

    public static int breakableCount = 0;


    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "Breakable");
        //keeping track of breakable bricks
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void HandleHits()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            breakableCount--;
            print(breakableCount);
            DestroyObject(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
    // TODO remove this method when we can actually win.
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

}
