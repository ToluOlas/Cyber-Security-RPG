using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class email : MonoBehaviour
{
    //email structure
    public string emailTopic;
    public string emailSender;
    public string emailRecipients;
    public string emailMessage;

    //email answer options
    public string option1;
    public string option2;
 
    // 1 - best, 2 - good, 3 - bad, 4 - very bad
    public int option1Result;
    public int option2Result;
    public int reportResult;

    //type of cybersecurity issue
    //safe, malicious, phishing, spoofing
    public string emailType;

    //if the email is a minigame type of email
    public bool isMinigame;
    //password, compose-email
    public string minigameType;

    //compose email minigame variables
    public string replyTitle;
    public string replyText;
    public string sendTo1;
    public string sendTo2;
    public string sendTo3;
    
    public int correctRecipient; //1 to 3

    public string attachment1;
    public string attachment2;
    public string attachment3;

    public int correctAttachment; //1 to 3
}
