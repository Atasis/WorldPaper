using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END : MonoBehaviour {

    public time time;
    public Move move;
    public Animator ani;
    // Use this for initialization
    void Start () {
        ani.SetBool("end", false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        move.CanMove = false;
        time.end = true;
        ani.SetBool("end", true);
    }
}
