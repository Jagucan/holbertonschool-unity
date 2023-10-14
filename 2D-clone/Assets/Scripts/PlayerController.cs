using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    enum Direction {left = -1, none = 0, right = 1};
    Direction currentDirection = Direction.none;
    public float speed;
    public float jump;
    Rigidbody2D mario;
    CollisionsController marioCollisions;

    private void Awake()
    {
        mario = GetComponent<Rigidbody2D>();
        marioCollisions = GetComponent<CollisionsController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentDirection = Direction.none;

        if (Input.GetKey(KeyCode.D))
        {
            //MoveRight();
            currentDirection = Direction.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //MoveLeft();
            currentDirection = Direction.left;
        }
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector2 speedVelocity = new((int)currentDirection * speed, mario.velocity.y);
        mario.velocity = speedVelocity;
    }
    void Jump()
    {
        if (marioCollisions.Grounded())
        {
            Vector2 jumpForce = new(0f, jump);
            mario.AddForce(jumpForce, ForceMode2D.Impulse);
        }
    }

    /*
    void MoveRight()
    {
        Vector2 speedVelocity = new(speed, 0f);
        mario.velocity = speedVelocity;
    }

    void MoveLeft()
    {
        Vector2 speedVelocity = new(-speed, 0f);
        mario.velocity = speedVelocity;
    }
    */

}
