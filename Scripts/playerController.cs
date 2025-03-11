using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed;

    private Animator myAnim;
    private Rigidbody2D myRB;

    private bool playerMoving;
    private Vector2 lastMove;

    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerMoving = false;

        if(!canMove)
        {
            myRB.velocity = Vector2.zero;
            myAnim.SetBool("playerMoving", playerMoving);
            return;
        }

        if (Input.GetAxisRaw("Horizontal") != 0f)
        {
            myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRB.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") != 0f)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        if(Input.GetAxisRaw("Horizontal") == 0f)
        {
            myRB.velocity = new Vector2(0f, myRB.velocity.y);
        }

        if(Input.GetAxisRaw("Vertical") == 0f)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, 0f);
        }

        myAnim.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
        myAnim.SetFloat("moveY", Input.GetAxisRaw("Vertical"));
        myAnim.SetBool("playerMoving", playerMoving);
        myAnim.SetFloat("lastX", lastMove.x);
        myAnim.SetFloat("lastY", lastMove.y);
    }
}
