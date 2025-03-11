using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class emailReplyMinigame : MonoBehaviour
{
    private gameManager theGameManager;
    private computerController theComputer;
    private scoreManager theScore;
    private emailManager eManager;

    //the email
    public TextMeshProUGUI originalEmailText;
    public TextMeshProUGUI theTitle;
    public TextMeshProUGUI theText;

    public TextMeshProUGUI recipient1;
    public TextMeshProUGUI recipient2;
    public TextMeshProUGUI recipient3;

    public TextMeshProUGUI file1;
    public TextMeshProUGUI file2;
    public TextMeshProUGUI file3;

    public TextMeshProUGUI chosenRecipient;
    public TextMeshProUGUI chosenFile;

    public GameObject sendButton;
    public GameObject replyScreen;

    private int recipientNum;
    private int fileNum;

    public GameObject recipientOptions;
    public GameObject fileOptions;

    public int currentIndex;

    

    // Start is called before the first frame update
    void Start()
    {
        eManager = FindObjectOfType<emailManager>();
        theGameManager = FindObjectOfType<gameManager>();
        theComputer = FindObjectOfType<computerController>();
        theScore = FindObjectOfType<scoreManager>();

        recipientNum = 0;
        fileNum = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(recipientNum != 0 && fileNum != 0)
        {
            sendButton.gameObject.SetActive(true);
        }

        currentIndex = eManager.currentEmail-1;
        
    }

    public void setupPage()
    {
        originalEmailText.text = eManager.emailQueue[currentIndex].emailMessage;

        theTitle.text = eManager.emailQueue[currentIndex].replyTitle;
        theText.text = eManager.emailQueue[currentIndex].replyText;

        recipient1.text = eManager.emailQueue[currentIndex].sendTo1;
        recipient2.text = eManager.emailQueue[currentIndex].sendTo2;
        recipient3.text = eManager.emailQueue[currentIndex].sendTo3;

        file1.text = eManager.emailQueue[currentIndex].attachment1;
        file2.text = eManager.emailQueue[currentIndex].attachment2;
        file3.text = eManager.emailQueue[currentIndex].attachment3;
    }

    public void openOptions(int box)
    {
        if(box==1)
        {
            recipientOptions.gameObject.SetActive(true);
        }
        else
        {
            fileOptions.gameObject.SetActive(true);
        }
    }

    public void closeOptions()
    {
        recipientOptions.gameObject.SetActive(false);
        fileOptions.gameObject.SetActive(false);
    }

    public void chooseRecipient(int choice)
    {
        recipientNum = choice;
        if(choice == 1)
        {
            chosenRecipient.text = eManager.emailQueue[currentIndex].sendTo1;
        }
        else if(choice == 2)
        {
            chosenRecipient.text = eManager.emailQueue[currentIndex].sendTo2;
        }
        else if(choice == 3)
        {
            chosenRecipient.text = eManager.emailQueue[currentIndex].sendTo3;
        }

        closeOptions();
    }

    public void chooseFile(int choice)
    {
        fileNum = choice;
        if(choice == 1)
        {
            chosenFile.text = eManager.emailQueue[currentIndex].attachment1;
        }
        else if(choice == 2)
        {
            chosenFile.text = eManager.emailQueue[currentIndex].attachment2;
        }
        else if(choice == 3)
        {
            chosenFile.text = eManager.emailQueue[currentIndex].attachment3;
        }

        closeOptions();
    }

    public void sendEmail()
    {
        chosenRecipient.text = "CLICK HERE";
        chosenFile.text = "CLICK HERE";
        theScore.emailReplyResult(recipientNum, fileNum);
        replyScreen.gameObject.SetActive(false);
    }
}
