using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    private Rigidbody2D rb;
    private Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
        //subtracts all 3 vector coordinates
        paddleToBallVector = this.transform.position - paddle.transform.position;
        this.rb = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = paddle.transform.position + paddleToBallVector;
        if(Input.GetMouseButtonDown(0))
        {
            print("mouse clicked, Launch Ball");

            this.rb.velocity = new Vector2(2f, 10f);
        }
	}
}
