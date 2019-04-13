using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 12f;
    public bool CanJump = false;
    public bool CanMove = true;
    
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            Vector3 v = Vector3.zero;
            v.y = rb.velocity.y;
            v.x = Input.GetAxis("Horizontal") * speed;
            if (Input.GetKeyDown(KeyCode.Space) && CanJump)
            {
                v.y = jumpforce;
            }
            rb.velocity = v;
            if (v.x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (v.x > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        
    }
}


