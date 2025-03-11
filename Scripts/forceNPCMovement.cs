using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceNPCMovement : MonoBehaviour
{
    public GameObject NPC;
    public string direction;
    //when player enters collider, force an npc to move in a certin direction
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            npcOfficeMovement theNPC = NPC.GetComponent<npcOfficeMovement>();
            theNPC.chooseDirection(direction);
            Destroy(gameObject);
        }
    }

    
}
