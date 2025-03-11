using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startWorkDay : MonoBehaviour
{
    //start prompt canvas
    public GameObject startPrompt;
    public GameObject PCTrigger;

    private computerController theComputer;
    private playerController thePlayer;
    private gameManager theGameManager;
    // Start is called before the first frame update
    void Start()
    {
        theComputer = FindObjectOfType<computerController>();
        thePlayer = FindObjectOfType<playerController>();
        theGameManager = FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            startPrompt.gameObject.SetActive(true);
            //stop player movement
        }
    }

    public void removePrompt()
    {
        Destroy(startPrompt);
        Destroy(gameObject);
    }

    public void hidePrompt()
    {
        startPrompt.gameObject.SetActive(false);
    }

    public void startSequence()
    {
        countdownTimer theTimer = FindObjectOfType<countdownTimer>();
        theTimer.beginTimer();
        //start the game
        theGameManager.gameStarted = true;
        theComputer.startComputer();
        //get tasks
        PCTrigger.gameObject.SetActive(true);
        removePrompt();
    }
}
