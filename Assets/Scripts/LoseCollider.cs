using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    //instiantiation of object will allow its exposure on Unity
    public LevelManager levelManager;

     void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger");
        levelManager.LoadLevel("Win");
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
