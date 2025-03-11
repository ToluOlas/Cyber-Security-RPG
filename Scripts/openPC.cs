using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPC : MonoBehaviour
{
    private bool pcInRange;
    public bool pcOpen;
    private computerController theComputer;
    // Start is called before the first frame update
    void Start()
    {
        pcInRange = false;
        theComputer = FindObjectOfType<computerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && pcOpen == false && pcInRange == true)
        {
            pcOpen = true;
            if(theComputer.loggedIn == false)
            {
                theComputer.logIn();
            }
            else 
            {
                theComputer.forceStart();
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            pcInRange = true;
            Debug.Log("Open your PC?");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            pcInRange = false;
            Debug.Log("I guess not...");
        }
    }
}
