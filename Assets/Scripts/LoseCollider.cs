using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    //instiantiation of object will allow its exposure on Unity
    private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Lose Screen");
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
