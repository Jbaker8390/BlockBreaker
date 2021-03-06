﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    //bring in multiple sprites
    public Sprite[] hitSprites;
    public AudioClip crack;
    public GameObject smoke;

    private int timesHit;
    private LevelManager levelManager;
    private bool isBreakable;


    public static int breakableCount = 0;


    // Use this for initialization
    void Start()
    {
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
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //places audio source at the brick position without brick needing to be there
        AudioSource.PlayClipAtPoint(crack, transform.position);
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
            //calls the level manager 
            levelManager.BrickDestroyed();
            PuffSmoke();         
            DestroyObject(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void PuffSmoke()
    {
        GameObject smokePuff = Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
        ParticleSystem.MainModule effect = smokePuff.GetComponent<ParticleSystem>().main;
        effect.startColor = GetComponent<SpriteRenderer>().color;
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("No Sprite Loaded");
        }
    }
    // TODO remove this method when we can actually win.
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

}
