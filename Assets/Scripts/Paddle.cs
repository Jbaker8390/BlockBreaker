using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public bool autoPlay = false;

    
    private Ball ball;

    private void Start()
    {
        //find ball in current instance can use print to verify
        ball = GameObject.FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update () {
        if (autoPlay == false)
        {
            MoveWithMouse();
        }else
        {
            AutoPlay();
        }
	}
    void AutoPlay()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        //converts position into how many game units wide from 0 - 16
        Vector3 ballPos = ball.transform.position;

        //constrains positional boundaries of mouse movement in frame
        paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);

        //the instance of the current game paddleScript of the paddle object
        this.transform.position = paddlePos;
    }
    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        //converts position into how many game units wide from 0 - 16
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        //constrains positional boundaries of mouse movement in frame
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);

        //the instance of the current game paddleScript of the paddle object
        this.transform.position = paddlePos;
    }

   
}
