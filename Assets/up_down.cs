using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_down : MonoBehaviour {

    public Transform middle;
    public float speed = 7f;
    public float maxDistance = 7.5f;
    public bool goup = true;
    public bool godown = false;

    private Rigidbody2D rb;
    private float nowDistance = 0;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        nowDistance = Vector2.Distance(transform.position, middle.position);
        if (nowDistance >= maxDistance && middle.position.y - transform.position.y < 0) //在上邊
        {
            goup = false;
            godown = true;
        }
        if (nowDistance >= maxDistance && middle.position.y - transform.position.y > 0) //在下邊
        {
            goup = true;
            godown = false;
        }
        if (goup)
        {
            rb.velocity = Vector2.up * speed;
        }
        if (godown)
        {
            rb.velocity = Vector2.down * speed;
        }
    }
}
