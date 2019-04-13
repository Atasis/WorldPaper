using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_left : MonoBehaviour {

    public Transform middle;
    public float speed = 7f;
    public float maxDistance = 7.5f;
    public bool goleft = true;
    public bool goright = false;

    private Rigidbody2D rb;
    private float nowDistance = 0;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        nowDistance = Vector2.Distance(transform.position , middle.position);
        if (nowDistance >= maxDistance && middle.position.x - transform.position.x > 0) //在左邊
        {
            goleft = false;
            goright = true;
        }
        if (nowDistance >= maxDistance && middle.position.x - transform.position.x < 0) //在右邊
        {
            goleft = true;
            goright = false;
        }
        if (goleft)
        {
            rb.velocity = Vector2.left * speed;
        }
        if (goright)
        {
            rb.velocity = Vector2.right * speed;
        }
    }
}
