using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    //instiantiation of object will allow its exposure on Unity
    private LevelManager levelManager;

    public void Start()
    {

        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        levelManager.LoadLevel("Win");
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
