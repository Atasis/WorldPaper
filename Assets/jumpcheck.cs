using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpcheck : MonoBehaviour {

    public Move move;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        move.CanJump = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        move.CanJump = false;
    }
}
