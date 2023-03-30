using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowDistance : MonoBehaviour
{
    private Transform Player;
    [SerializeField] private float moveSpeed;
    private SpriteRenderer sp;
    [SerializeField] private float distanceFollow;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sp = GetComponent<SpriteRenderer>();
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
            if (Vector3.Distance(this.transform.position,Player.transform.position) < distanceFollow)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.position, moveSpeed * Time.deltaTime);
            }
           

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
