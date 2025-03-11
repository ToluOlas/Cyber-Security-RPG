using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class emailManager : MonoBehaviour
{
    public List<email> emailQueue = new List<email>();
    private int emailCount;

    public GameObject emailBodyGraphic;
    public GameObject replyGraphic;

    //track which email is currently selected
    public int currentEmail;

    //selected email
    public TextMeshProUGUI selectedTopic;
    public TextMeshProUGUI selectedSender;
    public TextMeshProUGUI selectedRecipient;
    public TextMeshProUGUI selectedBody;

    public TextMeshProUGUI responseA;
    public TextMeshProUGUI responseB;

    //email 1
    public TextMeshProUGUI senderName1;
    public TextMeshProUGUI emailTopic1;
    public TextMeshProUGUI emailBody1;
    public Button emailButton1;

    //email 2
    public TextMeshProUGUI senderName2;
    public TextMeshProUGUI emailTopic2;
    public TextMeshProUGUI emailBody2;
    public Button emailButton2;

    //email 3
    public TextMeshProUGUI senderName3;
    public TextMeshProUGUI emailTopic3;
    public TextMeshProUGUI emailBody3;
    public Button emailButton3;

    //email 4
    public TextMeshProUGUI senderName4;
    public TextMeshProUGUI emailTopic4;
    public TextMeshProUGUI emailBody4;
    public Button emailButton4;

    //email 5
    public TextMeshProUGUI senderName5;
    public TextMeshProUGUI emailTopic5;
    public TextMeshProUGUI emailBody5;
    public Button emailButton5;

    // Start is called before the first frame update
    void Start()
    {
        updateInbox();
        currentEmail = 0;
    }

    // Update is called once per frame
    void Update()
    {
        emailCount = emailQueue.Count;
    }

    public void updateInbox()
    {
        int backOfQueue;
        bool blankEntries = false;
        int queueLength = emailQueue.Count;

        if (queueLength < 5)
        {
            //ensure that there are always 5 emails minimum in the queue
            backOfQueue = 5 - queueLength;
            blankEntries = true;

            for (int i = 0; i<backOfQueue; i++)
            {
                email blankEmail = new email
                {
                    emailTopic = "",
                    emailSender = "",
                    emailRecipients = "",
                    emailMessage = ""
                };

                emailQueue.Add(blankEmail);
            }
        }

        //updating all buttons
        senderName1.text = emailQueue[0].emailSender;
        emailTopic1.text = emailQueue[0].emailTopic;
        emailBody1.text = emailQueue[0].emailMessage;

        senderName2.text = emailQueue[1].emailSender;
        emailTopic2.text = emailQueue[1].emailTopic;
        emailBody2.text = emailQueue[1].emailMessage;

        senderName3.text = emailQueue[2].emailSender;
        emailTopic3.text = emailQueue[2].emailTopic;
        emailBody3.text = emailQueue[2].emailMessage;

        senderName4.text = emailQueue[3].emailSender;
        emailTopic4.text = emailQueue[3].emailTopic;
        emailBody4.text = emailQueue[3].emailMessage;

        senderName5.text = emailQueue[4].emailSender;
        emailTopic5.text = emailQueue[4].emailTopic;
        emailBody5.text = emailQueue[4].emailMessage;

        //remove blank entries
        if(blankEntries == true)
        {
            for (int i=4; i>=0; i--)
            {
                if(emailQueue[i].emailTopic == "")
                {
                    emailQueue.RemoveAt(i);
                }
            }
        }
    }
    
    public void removeEmail()
    {
        emailQueue.RemoveAt(currentEmail-1);
        emailBodyGraphic.SetActive(false);
        replyGraphic.SetActive(false);
        updateInbox();
    }

    public void showEmail1()
    {
        if(emailTopic1.text == "")
        {
            return;
        }
        else
        {
            currentEmail = 1;

            emailBodyGraphic.SetActive(true);
            replyGraphic.SetActive(false);

            selectedTopic.text = emailQueue[0].emailTopic;
            selectedSender.text = emailQueue[0].emailSender;
            selectedRecipient.text = emailQueue[0].emailRecipients;
            selectedBody.text = emailQueue[0].emailMessage;

            responseA.text = emailQueue[0].option1;
            responseB.text = emailQueue[0].option2;
        }
    }

    public void showEmail2()
    {
        if(emailTopic2.text == "")
        {
            return;
        }
        else
        {
            currentEmail = 2;

            emailBodyGraphic.SetActive(true);
            replyGraphic.SetActive(false);

            selectedTopic.text = emailQueue[1].emailTopic;
            selectedSender.text = emailQueue[1].emailSender;
            selectedRecipient.text = emailQueue[1].emailRecipients;
            selectedBody.text = emailQueue[1].emailMessage;

            responseA.text = emailQueue[1].option1;
            responseB.text = emailQueue[1].option2;
        }
    }

    public void showEmail3()
    {
        if(emailTopic3.text == "")
        {
            return;
        }
        else
        {
            currentEmail = 3;

            emailBodyGraphic.SetActive(true);
            replyGraphic.SetActive(false);

            selectedTopic.text = emailQueue[2].emailTopic;
            selectedSender.text = emailQueue[2].emailSender;
            selectedRecipient.text = emailQueue[2].emailRecipients;
            selectedBody.text = emailQueue[2].emailMessage;

            responseA.text = emailQueue[2].option1;
            responseB.text = emailQueue[2].option2;
        }
    }

    public void showEmail4()
    {
        if(emailTopic4.text == "")
        {
            return;
        }
        else
        {
            currentEmail = 4;

            emailBodyGraphic.SetActive(true);
            replyGraphic.SetActive(false);

            selectedTopic.text = emailQueue[3].emailTopic;
            selectedSender.text = emailQueue[3].emailSender;
            selectedRecipient.text = emailQueue[3].emailRecipients;
            selectedBody.text = emailQueue[3].emailMessage;

            responseA.text = emailQueue[3].option1;
            responseB.text = emailQueue[3].option2;
        }
    }

    public void showEmail5()
    {
        if(emailTopic5.text == "")
        {
            return;
        }
        else
        {
            currentEmail = 5;

            emailBodyGraphic.SetActive(true);
            replyGraphic.SetActive(false);

            selectedTopic.text = emailQueue[4].emailTopic;
            selectedSender.text = emailQueue[4].emailSender;
            selectedRecipient.text = emailQueue[4].emailRecipients;
            selectedBody.text = emailQueue[4].emailMessage;

            responseA.text = emailQueue[4].option1;
            responseB.text = emailQueue[4].option2;
        }
    }

    public void openReply()
    {
        replyGraphic.SetActive(true);
    }

    public void closeReply()
    {
        replyGraphic.SetActive(false);
    }
}
