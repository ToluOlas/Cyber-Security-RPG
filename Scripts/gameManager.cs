using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gameStarted;

    public bool gameEnded;

    public GameObject winDialogue;
    public GameObject loseDialogue;

    private dialogueTrigger theWinDialogue;
    private dialogueTrigger theLoseDialogue;

    public bool passwordGameActive;
    public GameObject scanner;
    public GameObject scannerpt2;

    public GameObject emailResponseScreen;

    private computerController theComputer;
    private emailManager eManager;
    private emailReplyMinigame replyManager;
    private countdownTimer theTimer;
    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
        gameEnded = false;
        passwordGameActive = false;
        theComputer = FindObjectOfType<computerController>();
        eManager = FindObjectOfType<emailManager>();
        replyManager = FindObjectOfType<emailReplyMinigame>();
        theTimer = FindObjectOfType<countdownTimer>();

        theWinDialogue = winDialogue.GetComponent<dialogueTrigger>();
        theLoseDialogue = loseDialogue.GetComponent<dialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        //end the game under certain conditions
        //if email is empty AND the password game is not active, end it
        if(passwordGameActive==false && eManager.emailQueue.Count <= 0 && gameStarted == true && gameEnded == false)
        {
            endTheGameWin();
        }
    }

    public void startPasswordGame()
    {
        passwordGameActive = true;
        scanner.gameObject.SetActive(true);
        scannerpt2.gameObject.SetActive(true);
        theComputer.logOut();
    }

    public void endPasswordGame()
    {
        passwordGameActive = false;
        //scanner.gameObject.SetActive(false);
        //scannerpt2.gameObject.SetActive(false);
    }

    public void composeEmail()
    {
        Debug.Log("TEST3");
        emailResponseScreen.gameObject.SetActive(true);
        replyManager.setupPage();
        theComputer.emailScreen.SetActive(false);
        Debug.Log("TEST4");
    }

    public void endTheGameWin()
    {
        theTimer.stopTimer();

        gameEnded = true;
        gameStarted = false;

        theWinDialogue.TriggerDialogue();
    }

    public void endTheGameLoss()
    {
        theTimer.stopTimer();
        
        gameEnded = true;
        gameStarted = false;

        theLoseDialogue.TriggerDialogue();
    }
}
