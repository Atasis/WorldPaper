using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tan : MonoBehaviour {

    public Transform point;

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(point.position.x , transform.position.y);
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" )
        {
            rb.velocity = Vector2.up * 25;
        }
    }
}
