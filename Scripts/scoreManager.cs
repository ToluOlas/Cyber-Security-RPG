using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreManager : MonoBehaviour
{
    public int currentScore;
    public TextMeshProUGUI scoreText;

    private int fourStrikes;
    private int tenStrikes;

    private emailManager eManager;
    private int currentIndex;
    private gameManager theGameManager;
    private computerController theComputer;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        fourStrikes = 0;
        tenStrikes = 0;

        eManager = FindObjectOfType<emailManager>();
        theGameManager = FindObjectOfType<gameManager>();
        theComputer = FindObjectOfType<computerController>();
    }

    // Update is called once per frame
    void Update()
    {
        currentIndex = eManager.currentEmail-1;

        if(fourStrikes == 4 || tenStrikes == 10)
        {
            Debug.Log("Game Over");
            fourStrikes = 0;
            tenStrikes = 0;
            theGameManager.endTheGameLoss();
            //end the game
            //you lose!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }

    public void chooseOption1()
    {
        //options rated 1 or 2 are good

        //if this email is a minigame, initiate minigame.
        if(eManager.emailQueue[currentIndex].isMinigame == true)
        {
            Debug.Log("Starting Minigame...");
            //startMinigame
            switch (eManager.emailQueue[currentIndex].emailType)
            {
                case "password":
                    Debug.Log("Password Minigame");
                    
                    if(theGameManager.passwordGameActive)
                    {
                        return;
                    }

                    theGameManager.startPasswordGame();
                    eManager.removeEmail();
                    break;

                case "compose-email":
                    Debug.Log("Compose Email Minigame");
                    theGameManager.composeEmail();
                    break;

                default:
                    Debug.Log("Invalid option");
                    eManager.removeEmail();
                    break;
            }    
        }
        else
        {
            if(eManager.emailQueue[currentIndex].option1Result <= 2)
            {
                Debug.Log("Good Answer!");
                addScore(100);
                eManager.removeEmail();
            }
            //options rated 3 or 4 are bad
            else if(eManager.emailQueue[currentIndex].option1Result > 2)
            {
                Debug.Log("Bad answer...");
                addScore(-50);
                tenStrikes += 1;
                if(eManager.emailQueue[currentIndex].option1Result == 4)
                {
                    fourStrikes += 1;
                }

                eManager.removeEmail();

            } 
        }
    }

    public void chooseOption2()
    {
        //options rated 1 or 2 are good
        if(eManager.emailQueue[currentIndex].option2Result <= 2)
        {
            Debug.Log("Good Answer!");
            addScore(100);
        }
        //options rated 3 or 4 are bad
        else if(eManager.emailQueue[currentIndex].option2Result > 2)
        {
            Debug.Log("No...");
            addScore(-50);
            tenStrikes += 1;

            if(eManager.emailQueue[currentIndex].option2Result == 4)
            {
                fourStrikes += 1;
            }
        } 
        eManager.removeEmail();
    }

    public void chooseReport()
    {
        //options rated 1 or 2 are good
        if(eManager.emailQueue[currentIndex].reportResult <= 2)
        {
            Debug.Log("Good Answer!");
            addScore(100);
        }
        //options rated 3 or 4 are bad
        else if(eManager.emailQueue[currentIndex].reportResult > 2)
        {
            Debug.Log("No...");
            addScore(-100);
            tenStrikes += 1;

            if(eManager.emailQueue[currentIndex].reportResult == 4)
            {
                fourStrikes += 1;
            }
        } 

        eManager.removeEmail();
    }

    public void passwordMinigameResult(bool guessed, int guessesLeft, bool isPassStrong)
    {
        if(guessed)
        {
            switch (guessesLeft)
            {
                case 3:
                    Debug.Log("You got it easy!");
                    addScore(100);
                    break;
                case 2:
                    Debug.Log("Minor Hiccup!");
                    addScore(50);
                    break;
                case 1:
                    Debug.Log("Thin ice");
                    addScore(25);
                    break;
            }
        }
        else
        {
            Debug.Log("Did not guess the password");
            tenStrikes += 1;
            fourStrikes += 1; 
            addScore(-200);
        }

        if(isPassStrong)
        {
            Debug.Log("Nice Password");
            addScore(50);
        }
        else
        {
            Debug.Log("Password was weak...");
            fourStrikes += 1;
            tenStrikes += 1;
            addScore(-100);
        }

        theGameManager.endPasswordGame();
    }

    public void emailReplyResult(int recipientNum, int fileNum)
    {
        if(eManager.emailQueue[currentIndex].correctRecipient == recipientNum)
        {
            if(eManager.emailQueue[currentIndex].correctAttachment == fileNum)
            {
                Debug.Log("Correct Email Composed!");
                addScore(150);
            }
            else
            {
                Debug.Log("Incorrect Attachment Sent...");
                fourStrikes += 1;
                tenStrikes += 1;
                addScore(-50);
            }
        }

        else
        {
            Debug.Log("Incorrect Recipients...");
            addScore(-50);
            fourStrikes += 1;
            tenStrikes += 1;
        }

        theComputer.emailScreen.SetActive(true);
        eManager.removeEmail();
    }

    public void badConnection()
    {
        Debug.Log("Unstable network, you are at risk!");
        addScore(-50);
        tenStrikes += 1;
    }

    public void brokenDevice()
    {
        Debug.Log("Fix the device!");
        addScore(-10);
        
    }

    public void vulnerablePC()
    {
        Debug.Log("NPC has accessed your PC");
        addScore(-100);
        tenStrikes += 1;
        fourStrikes += 1;
    }

    private void addScore(int points)
    {
        currentScore += points;

        scoreText.text = currentScore.ToString();

        if(points > 0)
        {
            scoreText.color = Color.green;
        }
        else if(points <= 0)
        {
            scoreText.color = Color.red;
        }
    }
    

}
