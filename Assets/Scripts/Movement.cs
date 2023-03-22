using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D mybody;
    private SpriteRenderer sp;
    [SerializeField] private float speedX, speedY;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
    }

   

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if ( h == 0 && v == 0)
        {
            anim.SetBool("anim", false);
        }
        
        if(h > 0)
        {
            mybody.velocity = new Vector2(speedX, mybody.velocity.y);
            sp.flipX = false;
            anim.SetBool("anim", true);
        }
        else if (h < 0)
        {
            mybody.velocity = new Vector2(-speedX, mybody.velocity.y);
            sp.flipX = true;
            anim.SetBool("anim", true);
        }
        else
        {
            mybody.velocity = new Vector2(0f, mybody.velocity.y);
        }

        if(v > 0)
        {
            mybody.velocity = new Vector2(mybody.velocity.x, speedY);
            anim.SetBool("anim", true);
        }
        else if (v < 0)
        {
            mybody.velocity = new Vector2(mybody.velocity.x, -speedY);
            anim.SetBool("anim", true);
        }
        else
        {
            mybody.velocity = new Vector2(mybody.velocity.x, 0f);
        }
    }
}
