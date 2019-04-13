using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goback : MonoBehaviour {

    public Transform gotoback;
    public bachi_times bachi_times;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = gotoback.position;
            bachi_times.bachi += 1;
        }
        if (collision.gameObject.tag == "trap")
        {

            Destroy(collision.gameObject);
        }
    }

}
