using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    private Rigidbody2D rb;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    // Use this for initialization
    void Start()
    {
        //subtracts all 3 vector coordinates
        paddleToBallVector = this.transform.position - paddle.transform.position;
        this.rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            //lock ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;
            //wait until mouse click to launch the ball
            if (Input.GetMouseButtonDown(0))
            {
                print("mouse clicked, Launch Ball");
                hasStarted = true;
                //lauching this objects rigidbody in a certain direction
                this.rb.velocity = new Vector2(2f, 10f);
            }
        }

    }
}
