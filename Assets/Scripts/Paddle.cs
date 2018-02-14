using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        //converts position into how many game units wide from 0 - 16
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        //constrains positional boundaries of mouse movement in frame
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);

        //the instance of the current game paddleScript of the paddle object
        this.transform.position = paddlePos;
	}

   
}
