using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //converts position into how many game units wide from 0 - 16
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        print(mousePosInBlocks);

	}
}
