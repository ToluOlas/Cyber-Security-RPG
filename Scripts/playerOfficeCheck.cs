using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class for checking the status of player workspace
public class playerOfficeCheck : MonoBehaviour
{

    public bool inCubicle;
    public bool npcInCubicle;

    private int cubicleSum;

    private computerController theComputer;
    private scoreManager theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        inCubicle = true;

        npcInCubicle = false;
        cubicleSum = 0;
        theComputer = FindObjectOfType<computerController>();
        theScoreManager = FindObjectOfType<scoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            inCubicle = true;
            Debug.Log("Entering Workspace...");
        }

        if(other.gameObject.tag == "NPC")
        {
            cubicleSum = cubicleSum + 1;
            npcInCubicle = true;
            Debug.Log("NPC entering Workspace...");

            //NPC attempts to tamper with users PC
            if(!inCubicle && theComputer.loggedIn)
            {
                int tamperChance = Random.Range(0,2);

                if(tamperChance == 1)
                {
                    theScoreManager.vulnerablePC();
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            inCubicle = false;
            Debug.Log("Exiting Workspace...");
        }

        if(other.gameObject.tag == "NPC")
        {
            cubicleSum = cubicleSum - 1;
            Debug.Log("NPC exiting Workspace...");
            if(cubicleSum <= 0)
            {
                npcInCubicle = false;
            }
        }
    }
}
