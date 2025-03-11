using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMovementController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    private Rigidbody2D myRB;

    private Animator myAnim;
    private Vector2 lastMove;

    public bool isWalking;

    public float walkTime;
    public float waitTime;

    private float walkCounter;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkZone;
    private bool hasWalkZone = false;

    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        
        waitCounter = waitTime;
        walkCounter = walkTime;

        chooseDirection();

        //only get boundaries for existing walk zone
        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }

        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {

        myAnim.SetBool("isMoving", isWalking);
        if(!canMove)
        {
            myRB.velocity = Vector2.zero;
            return;
        }

        if(isWalking)
        {
            walkCounter -= Time.deltaTime;

            //npc moves in direction
            switch(walkDirection)
            {
                case 0:
                    //up
                    myRB.velocity = new Vector2(0, moveSpeed);
                    lastMove = new Vector2(0, moveSpeed);
                    if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 1:
                    //right
                    myRB.velocity = new Vector2(moveSpeed, 0);
                    lastMove = new Vector2(moveSpeed, 0);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 2:
                    //down
                    myRB.velocity = new Vector2(0, -moveSpeed);
                    lastMove = new Vector2(0, -moveSpeed);
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 3:
                    //left
                    myRB.velocity = new Vector2(-moveSpeed, 0);
                    lastMove = new Vector2(-moveSpeed, 0);
                    if (hasWalkZone && transform.position.x < minWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
            }

            if(walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }

        }
        else
        {
            waitCounter -= Time.deltaTime;
            //stop moving
            myRB.velocity = Vector2.zero;

            if(waitCounter < 0)
            {
                chooseDirection();
            }
        }

        myAnim.SetFloat("MoveX", myRB.velocity.x);
        myAnim.SetFloat("MoveY", myRB.velocity.y);
        myAnim.SetFloat("LastMoveX", lastMove.x);
        myAnim.SetFloat("LastMoveY", lastMove.y);
    }

    // random selection of which direction npc will move in
    public void chooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
