using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeNpcDirection : MonoBehaviour
{
    public bool canMoveUp;
    public bool canMoveRight;
    public bool canMoveDown;
    public bool canMoveLeft;

    private npcOfficeMovement theNPC;

    private System.Random random = new System.Random(); 

    private int chosenDirection;

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "NPC")
        {
            theNPC = other.GetComponent<npcOfficeMovement>();

            theNPC.chooseDirection(switchDirection());
        }
    }

    private string switchDirection()
    {
        List<string> possibleDirections = new List<string>();

        // Add all possible movement directions to the list
        if (canMoveLeft)
        {
            possibleDirections.Add("left");
        }
        if (canMoveRight)
        {
            possibleDirections.Add("right");
        }
        if (canMoveUp)
        {
            possibleDirections.Add("up");
        }
        if (canMoveDown)
        {
            possibleDirections.Add("down");
        }

        // Check if there are any possible directions
        if (possibleDirections.Count == 0)
        {
            return "stop";
        }
        else
        {
            // choose random direction from list
            int chosenIndex = random.Next(possibleDirections.Count);
            return possibleDirections[chosenIndex];
        }
    }
}
