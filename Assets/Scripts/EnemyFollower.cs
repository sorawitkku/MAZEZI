using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{

    private Transform Player;
    [SerializeField] private float moveSpeed;
    private SpriteRenderer sp;
    private Animator anim;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    private void Update()
    {
        move();
        faceDirection();
 
    }

    protected virtual void move()
    {
        if (Player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, moveSpeed * Time.deltaTime);
            anim.SetBool("Run", true);
        }

    }

    protected void faceDirection()
    {
        if (transform.position.x > Player.position.x)
            sp.flipX = true;
        else
            sp.flipX = false;

    }
}
