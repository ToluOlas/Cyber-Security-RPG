using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcOfficeMovement : MonoBehaviour
{
    private float moveSpeed;

    public bool isScripted;

    public float scriptedSpeed;

    public string startDirection;

    public string startFacing;

    private bool hasMoved = false;

    private Rigidbody2D myRB;
    private Animator myAnim;
    private Vector2 lastMove;

    public int walkDirection;
    public bool isWalking;

    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();

        moveSpeed = Random.Range(2.0f, 6.0f);

        if (startDirection != null)
        {
            chooseDirection(startDirection);
        }
        else
        {
            chooseDirection("left");
        }

        if(isScripted)
        {
            moveSpeed = scriptedSpeed;
        }      

        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!canMove)
        {
            myRB.velocity = Vector2.zero;
            return;
        }

        if(isWalking)
        {

            //npc moves in direction
            switch(walkDirection)
            {
                case 0:
                    //up
                    myRB.velocity = new Vector2(0, moveSpeed);
                    lastMove = new Vector2(0, moveSpeed);
                    break;
                case 1:
                    //right
                    myRB.velocity = new Vector2(moveSpeed, 0);
                    lastMove = new Vector2(moveSpeed, 0);
                    break;
                case 2:
                    //down
                    myRB.velocity = new Vector2(0, -moveSpeed);
                    lastMove = new Vector2(0, -moveSpeed);
                    break;
                case 3:
                    //left
                    myRB.velocity = new Vector2(-moveSpeed, 0);
                    lastMove = new Vector2(-moveSpeed, 0);
                    break;
                default:
                    myRB.velocity = Vector2.zero;
                    break;
            }
        }
        else
        {
            myRB.velocity = Vector2.zero;
        }

        if(hasMoved)
        {
            myAnim.SetFloat("MoveX", myRB.velocity.x);
            myAnim.SetFloat("MoveY", myRB.velocity.y);
            myAnim.SetFloat("LastMoveX", lastMove.x);
            myAnim.SetFloat("LastMoveY", lastMove.y);
            myAnim.SetBool("isMoving", isWalking);
        }
        else
        {
            switch(startFacing)
            {
                case "up":
                    myAnim.SetFloat("LastMoveY", 10.0f);
                    break;
                case "right":
                    myAnim.SetFloat("LastMoveX", 10.0f);
                    break;
                case "down":
                    myAnim.SetFloat("LastMoveY", -10.0f);
                    break;
                case "left":
                    myAnim.SetFloat("LastMoveX", -10.0f);
                    break;
            }
        }
        
        
    }

    public void chooseDirection(string direction)
    {
        switch (direction)
        {
            case "up":
                walkDirection = 0;
                break;
            case "right":
                walkDirection = 1;
                break;
            case "down":
                walkDirection = 2;
                break;
            case "left":
                walkDirection = 3;
                break;
            case "stop":
                walkDirection = 4;
                break;
        }
        if(walkDirection == 4)
        {
            isWalking = false;
        }
        else
        {
            isWalking = true;
            hasMoved = true;
        }
    }
}
