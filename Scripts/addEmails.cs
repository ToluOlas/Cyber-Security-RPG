using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addEmails : MonoBehaviour
{
    private emailManager eManager;

    public int levelNumber;
    // Start is called before the first frame update
    void Start()
    {
        eManager = FindObjectOfType<emailManager>();

        switch (levelNumber)
        {
            case 0:
                loadLevelZero();
                break;
            case 1:
                loadLevelOne();
                break;
            case 2:
                loadLevelTwo();
                break;
            case 3:
                loadLevelThree();
                break;
            case 4:
                loadLevelFour();
                break;
        }
    }
    private void loadLevelZero()
    {
        email blankEmail = new email
        {
            emailTopic = "Send File Pls",
            emailSender = "Monty Gator <mgator@corp.com>",
            emailRecipients = "Steve O'Donnel, Mark Robert and 100 others",
            emailMessage = "Hello!, Pls send File..... I have been waiting for it for 24 hours",
            option1 = "Send over the file.",
            option2 = "'Boy if you don't get out of my inbox right this instant...'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        email blankEmail2 = new email
        {
            emailTopic = "Could you buy my mixtape?",
            emailSender = "J Tracks <tracksj@mixer.com>",
            emailRecipients = "Steve O'Donnel and 100 others",
            emailMessage = "Wsg gang, my new mix tape just dropped. Heres the link man, please give it a listen",
            option1 = "Open the link",
            option2 = "'Im blocking you lil bro'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail2);

        email blankEmail3 = new email
        {
            emailTopic = "[IMPORTANT] Document Scan Request",
            emailSender = "Mark Robert <mRobert@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello Steve. I left a document on your desk this morning that I would like you to scan some copies for. This will be important for a meeting we have next week with some stakeholders. Thank you.",
            option1 = "'Will do, sir'",
            option2 = "'Please refrain from contacting this email again'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "password",
            isMinigame = true
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Welcome to the Company!",
            emailSender = "HR <hr@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nWelcome to Corpo! We're excited to have you on board. If you have any questions or need assistance, feel free to reach out to the HR department. Wishing you a successful journey with us.\n\nBest regards,\nHR Department",
            option1 = "'Thank you!'",
            option2 = "'I'm ready to get started.'",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent: Security Update Required!",
            emailSender = "IT <it-suppart@gmail.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nWe've detected a security breach in your account. To secure your information, please click the following link to update your password immediately: git.ac.ru/7384592. Failure to do so may result in account suspension.\n\nThank you,\nIT Support",
            option1 = "Update Password",
            option2 = "'No thanks.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "[IMPORTANT] Company Announcement",
            emailSender = "Samantha Golds <sgolds@corp.com>",
            emailRecipients = "Steve O'Donnel, James Arlong and 137 others",
            emailMessage = "Dear Everyone,\n\nWe are pleased to announce a company-wide online meeting next week to discuss exciting upcoming projects and initiatives. Your attendance is highly encouraged. Details will follow soon.\n\nBest regards,\nSamantha Golds",
            option1 = "'I'll be there!'",
            option2 = "'I'm busy.'",
            option1Result = 1,
            option2Result = 2,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Account Verification Required!",
            emailSender = "IT <account@oneuseemails.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nYour account requires urgent verification. Please click the link below to confirm your identity. Failure to do so may result in account suspension.\n zxc/redeemgiftcard.au\n\nThank you,\nAccount Services",
            option1 = "Verify your account",
            option2 = "'I'll be fine, actually.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail3);

        email blankEmail4 = new email
        {
            emailTopic = "Finance Team File Request",
            emailSender = "Sarah Jane <sJane@corp.com>",
            emailRecipients = "Steve O'Donnel and 4 others",
            emailMessage = "Good Morning, everyone. My team has yet to recieve the latest report on our savings? Im not sure who to get in contact with for this, please let me know if you have it. The finance team require it.",
            option1 = "REPLY",
            option2 = "'I don't.'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "Finance Report [March 2024]",
            replyText = "Good Morning. I have attached the finance results for this month. Please refer to the attachment below. Thank you.",
            sendTo1 = "CORP-ALL",
            sendTo2 = "CORP-FINANCE",
            sendTo3 = "Sarah Jane, Mark Robert and 100 others",
            correctRecipient = 2,
            attachment1 = "family_photo.png",
            attachment2 = "my_performance_report.html",
            attachment3 = "2024_march_finance.doc",
            correctAttachment = 3
        };

        eManager.emailQueue.Add(blankEmail4);
        eManager.emailQueue.Add(blankEmail2);
        eManager.emailQueue.Add(blankEmail3);
        eManager.emailQueue.Add(blankEmail4);
        eManager.updateInbox();
    }

    private void loadLevelOne()
    {
        email blankEmail = new email
        {
            emailTopic = "Your first email!",
            emailSender = "Fred Jones <fjones@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello Steve! It's me your line manager.\n\nYou will recieve many emails such as this during your daily shifts, please make sure to address every email before you leave for the day. It's how you will be informed about all your tasks.",
            option1 = "'Got it.'",
            option2 = "'Interesting...'",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "The Basics",
            emailSender = "Fred Jones <fjones@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Every email has two options: Reply or Report. Well, technically three options, as you will often have two response options for each email. \n\nMake sure to read your emails properly! All company emails will end in '@corp.com'",
            option1 = "'Got it.'",
            option2 = "'Interesting...'",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "New Team Member",
            emailSender = "Mark Robert <mrobert@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Hello, everyone.\n\nI would like to welcome Steve to our corporation. He will be joining our Data and Communications department, you will be able to rely on him for any and ALL queries! Well, give him some time. Let's all give him a warm welcome!",
            option1 = "'Thank you!'",
            option2 = "'I'd rather not be contacted...'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Welcome, Steve!",
            emailSender = "James Arlong <jarlong@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Welcome to Corpo, Steve.\n\nHope you have a good time here. Could I get your LinkedIn? I would love to stay connected!",
            option1 = "'Sure'",
            option2 = "'I'd rather not...'",
            option1Result = 1,
            option2Result = 2,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Could you buy my mixtape?",
            emailSender = "J Tracks <tracksj@mixer.com>",
            emailRecipients = "Steve O'Donnel and 100 others",
            emailMessage = "Wsg gang, \n\nmy new mix tape just dropped. Heres the link man, please give it a listen",
            option1 = "Open the link",
            option2 = "'No thank you.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "[IMPORTANT] Enable 2FA",
            emailSender = "EmailSystem <helpdesk@corp.com>",
            emailRecipients = "Steve O'Donnel, Mark Robert",
            emailMessage = "Hello Steve,\n\nPlease complete your two factor authentication to make your account more secure.",
            option1 = "Complete Two Factor Authentication",
            option2 = "'I'd rather not...'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Welcome to the Company!",
            emailSender = "HR <hr@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nWelcome to Corpo! We're excited to have you on board. If you have any questions or need assistance, feel free to reach out to the HR department. Wishing you a successful journey with us.\n\nBest regards,\nHR Department",
            option1 = "'Thank you!'",
            option2 = "'I'm ready to get started.'",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent: Security Update Required!",
            emailSender = "IT <it-suppart@gmail.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nWe've detected a security breach in your account. To secure your information, please click the following link to update your password immediately: git.ac.ru/7384592. Failure to do so may result in account suspension.\n\nThank you,\nIT Support",
            option1 = "Update Password",
            option2 = "'No thanks.'",
            option1Result = 4, 
            option2Result = 2, 
            reportResult = 1, 
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "[IMPORTANT] Company Announcement",
            emailSender = "Samantha Golds <sgolds@corp.com>",
            emailRecipients = "Steve O'Donnel, James Arlong and 137 others",
            emailMessage = "Dear Everyone,\n\nWe are pleased to announce a company-wide online meeting next week to discuss exciting upcoming projects and initiatives. Your attendance is highly encouraged. Details will follow soon.\n\nBest regards,\nSamantha Golds",
            option1 = "'I'll be there!'",
            option2 = "'I'm busy.'",
            option1Result = 1,
            option2Result = 2,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Account Verification Required!",
            emailSender = "IT <account@oneuseemails.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nYour account requires urgent verification. Please click the link below to confirm your identity. Failure to do so may result in account suspension.\n zxc/redeemgiftcard.au\n\nThank you,\nAccount Services",
            option1 = "Verify your account",
            option2 = "'I'll be fine, actually.'",
            option1Result = 4, 
            option2Result = 2, 
            reportResult = 1, 
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Team Collaboration Meeting",
            emailSender = "David Spencer <dspencer@corp.com>",
            emailRecipients = "CORP-DATACOM and 2 others",
            emailMessage = "Hi Team,\n\nLet's schedule a collaboration meeting to discuss our ongoing projects and share updates. Please suggest your preferred time slots.\n\nBest regards,\nDavid",
            option1 = "'I suggest Monday at 2 PM.'",
            option2 = "'This is a bit suspicious...'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Update Your Employee Profile",
            emailSender = "E-Services <employeeservices@cirp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nWe need you to update your employee profile with some additional information. Please follow the link below to complete the process.\ncirpo.com/info/git-trojan\n\nThanks,\nEmployee Services",
            option1 = "'I'll update my profile.'",
            option2 = "'Reporting.'",
            option1Result = 4, // High risk for providing personal information
            option2Result = 2, // Positive result for reporting phishing
            reportResult = 1, // Positive result for reporting phishing
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Invoice Payment Reminder",
            emailSender = "Billing <billing@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nThis is a friendly reminder that your invoice payment of $0.50 for the employee magazine due by the end of the week. To avoid late fees, please make the payment using the following secure link: corpo.com/user-profile/yourpayments.\n\nThank you,\nBilling Department",
            option1 = "'Thank you for letting me know.'",
            option2 = "'Nice try, hacker'",
            option1Result = 1,
            option2Result = 3, 
            reportResult = 4, 
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Project Update - Team Alpha",
            emailSender = "Kevin Alan <kalan@proc.com>",
            emailRecipients = "Steve O'Donnel and 13 others",
            emailMessage = "Hello Team,\n\nHere's a quick update on our project progress: proc.com/newsletter/ysbaczx. Great job so far! Let's keep up the momentum.\n\nRegards,\nKevin",
            option1 = "'Got it'",
            option2 = "'No thanks'",
            option1Result = 3,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Project Update - Team Alpha",
            emailSender = "Kevin Alan <kalan@corp.com>",
            emailRecipients = "CORP-DATACOM, CORP-SALES",
            emailMessage = "Hello Team,\n\nHere's a quick update on our project progress: corpo.com/newsletter/team-alpha. Great job so far! Let's keep up the momentum.\n\nRegards,\nKevin",
            option1 = "'Got it'",
            option2 = "'No thanks'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "...",
            emailSender = "Anonymous <anon@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "You won't last here long. Don't get comfortable, buddy. You're not built for the big leagues",
            option1 = "Forward to Line Manager",
            option2 = "'Try me then.'",
            option1Result = 1,
            option2Result = 2,
            reportResult = 1,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        eManager.updateInbox(); //16 emails
    }


    private void loadLevelTwo()
    {
        email blankEmail = new email
        {
            emailTopic = "Your Employee ID",
            emailSender = "Fred Jones <fjones@corp.com>",
            emailRecipients = "Steve O'Donnel, Mark Robert",
            emailMessage = "Hello Steve,\n\nI forgot to ask you, could I get the picture that you took for your employee ID? I would like to send the request to get it printed out so you can have a nice badge like the rest of us!\n\nRegards,\nFred",
            option1 = "REPLY",
            option2 = "'No thanks'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "My ID Photo",
            replyText = "Morning, Fred \n\nI have attached my photo on this email for you.",
            sendTo1 = "CORP-ALL",
            sendTo2 = "Fred Jones",
            sendTo3 = "Fred Jones, Sara Jane and 4 others",
            correctRecipient = 2,
            attachment1 = "my_photo.png",
            attachment2 = "progress_report.html",
            attachment3 = "2024_march_finance.doc",
            correctAttachment = 1
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Project Update - Team Alpha",
            emailSender = "Kevin Alan <kalan@corp.com>",
            emailRecipients = "CORP-DATACOM, CORP-SALES",
            emailMessage = "Hello Team,\n\nHere's the latest update on our project progress: corpo.com/newsletter/team-alpha. Our momentum seems unstoppable! Lets keep going.\n\nRegards,\nKevin",
            option1 = "'I'll read it soon'",
            option2 = "'No thanks'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent: Security Update Required!",
            emailSender = "IT <it-suppart@gmail.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nWe've detected a security breach in your account. To secure your information, please click the following link to update your password immediately: git.ac.ru/7384592. Failure to do so may result in account suspension.\n\nThank you,\nIT Support",
            option1 = "Update Password",
            option2 = "'No thanks.'",
            option1Result = 4, 
            option2Result = 2, 
            reportResult = 1, 
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Give me Datacom Portal Access",
            emailSender = "Kyle Smith <ksmith@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hey Steve,\n\nThere's been a large error with the sales figures. I accidentally entered some values incorrectly, could I get access to the datacom teams portal? Please man, i'll get in trouble if they find out. \n\nKyle",
            option1 = "'Sure'",
            option2 = "'I am not allowed'",
            option1Result = 4, 
            option2Result = 1, 
            reportResult = 2, 
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "DataCom Floor Devices",
            emailSender = "Mark Robert <mrobert@corp.com>",
            emailRecipients = "Steve O'Donnel, Fred Jones",
            emailMessage = "Hey, Steve.\n\n I hope you're keeping an eye on the devices on the floor like I asked. I would rather not deal with any complaints today",
            option1 = "'I sure am!'",
            option2 = "'I'd rather not be contacted...'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Finance Team File Request",
            emailSender = "Sarah Jane <sJane@corp.com>",
            emailRecipients = "Steve O'Donnel and 4 others",
            emailMessage = "Good Morning, everyone.\n\n My team has yet to recieve the latest report on our savings? Im not sure who to get in contact with for this, please let me know if you have it. The finance team require it.\n\n Sarah",
            option1 = "REPLY",
            option2 = "'I don't.'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "Finance Report [March 2024]",
            replyText = "Good Morning. I have attached the finance results for this month. Please refer to the attachment below. Thank you.",
            sendTo1 = "CORP-ALL",
            sendTo2 = "CORP-FINANCE",
            sendTo3 = "Sarah Jane, Mark Robert and 100 others",
            correctRecipient = 2,
            attachment1 = "family_photo.png",
            attachment2 = "my_performance_report.html",
            attachment3 = "2024_march_finance.doc",
            correctAttachment = 3
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Data Analytics Workshop",
            emailSender = "Linda Mayer <lmayer@corp.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Hi Team,\n\nWe're hosting a workshop on advanced data analytics techniques next Friday in the conference room. This is a great opportunity to enhance our skills and learn about the latest tools. Please RSVP by Wednesday if you're interested in attending.\n\nBest,\nLinda Mayer",
            option1 = "'Count me in!'",
            option2 = "'No thanks'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent: Performance Reports",
            emailSender = "Patrick Klein <pklein@hotmail.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Hello everyone,\n\nI am pleased to announce that I have been assigned as the brand new owner of Corpo at the 'Somewhereville' location. Could all teams please send their current progress reports?\n\nThank you,\nPatrick",
            option1 = "REPLY",
            option2 = "'No thanks.'",
            option1Result = 4, 
            option2Result = 2, 
            reportResult = 1, 
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "I will find you.",
            emailSender = "Mark Robert <mrobert@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "I don't know which idiot called 'Patrick' decided it would be funny to send that fake email about taking my job, but I traced it down to someone on the sales floor. \n\n You all have 30 minutes to figure out who sent that email or i'm firing all of you up there.",
            option1 = "'Damn...'",
            option2 = "Don't get involved",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "New Hire Onboarding Information",
            emailSender = "HR <hr@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nHere's some important information for your onboarding process, including your schedule, training materials, and office location details: corpo.com/new-hire/training/docxz.doc\n\nBest regards,\nHR Department",
            option1 = "'Got it. Thanks!'",
            option2 = "'I'll be fine'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        email phishingEmail9 = new email
        {
            emailTopic = "Boost Your Productivity!",
            emailSender = "John Smith <john.smith@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nI hope this email finds you well. I recently came across an amazing productivity tool that I've been using and thought you might find it useful too. It's called 'ProductivityMaster' and has helped me streamline my workflow and achieve better results.\n\nYou can download it for free by clicking the link below:\nproductivitymaster.com/download\n\nLet me know if you have any questions!\n\nBest regards,\nJohn Smith",
            option1 = "'Thanks for the recommendation.'",
            option2 = "'Are you sure this is safe?'",
            option1Result = 4, // High risk for clicking on unknown tool link
            option2Result = 1, // Positive result for reporting phishing
            reportResult = 1, // Positive result for reporting phishing
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(phishingEmail9);

        email blankEmail2 = new email
        {
            emailTopic = "New Track just Dropped!",
            emailSender = "J Tracks <tracksj@mixer.com>",
            emailRecipients = "Steve O'Donnel and 100 others",
            emailMessage = "Wsg gang,\n\n Newest track didn't do so well, but this one is sure to knock your socks off! Please give it a listen!",
            option1 = "Open the link",
            option2 = "'Please stop contacting me.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail2);

        blankEmail = new email
        {
            emailTopic = "[Urgent] Ticket Investigation",
            emailSender = "Rachel Green <rgreen@corp.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Good Morning, everyone.\n\nWe have quite a pressing issue. It seems that a fake ticket was sent in one of our customers names to steal their information. We would like your help in investigating this, could you send me the ticket history regarding the user 'Brady Cliff'?\n\n Rachel",
            option1 = "REPLY",
            option2 = "'I can't do that'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "Ticket History of B. Cliff",
            replyText = "Good Morning. I have attached the requested file. Please refer to the attachment below. Thank you.",
            sendTo1 = "Brady Cliff",
            sendTo2 = "CORP-HR",
            sendTo3 = "Rachel Green",
            correctRecipient = 3,
            attachment1 = "tickets_2020-2024.doc",
            attachment2 = "b.cliff_tickets_ALL.doc",
            attachment3 = "2024_march_finance.doc",
            correctAttachment = 2
        };

        eManager.emailQueue.Add(blankEmail);

        email complaintEmail = new email
        {
            emailTopic = "Complaint Regarding Customer Service",
            emailSender = "Miles <laurenM@hotmail.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Hello,\n\nI am writing to express my dissatisfaction with the recent interaction I had with one of your team members. During my call, the representative abruptly hung up on me, which left me feeling frustrated and unheard.\n\nI expect better customer service from your team and would appreciate it if you could address this matter promptly. Please investigate and take appropriate action.\n\nSincerely,\nMiles Lauren",
            option1 = "'I'll forward this to customer support.'",
            option2 = "'I'll handle it personally.'",
            option1Result = 1, 
            option2Result = 3, 
            reportResult = 3, 
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(complaintEmail);

        email phishingEmail11 = new email
        {
            emailTopic = "Important Meeting Invitation",
            emailSender = "Fred Jones <fjones@gmail.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nYou're invited to an urgent meeting tomorrow regarding the recent project updates. Click the link below to view the meeting details and agenda.\ngit.com/meeting-wdfgh\n\nBest,\nFred Jones",
            option1 = "'I'll attend the meeting.'",
            option2 = "'No thanks.'",
            option1Result = 4, // High risk for clicking on unknown meeting link
            option2Result = 1, // Positive result for reporting phishing
            reportResult = 1, // Positive result for reporting phishing
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(phishingEmail11);

        blankEmail = new email
        {
            emailTopic = "New Marketing Figures for us",
            emailSender = "Tim Butler <tbutler@corp.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Hey guys,\n\nMarketing has sent us their latest figures on how well the latest campaign did. Let get onto it.\n\ndocs.com/mrkt-campaign\n\nTim",
            option1 = "Open link",
            option2 = "'No thanks'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Data for Research",
            emailSender = "John Asher <jasher@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hey Steve,\n\nI am currently working on a project that could help us automate our email system by taking data from back-end and using its information to update stakeholders automatically.\n\nCould I get access to the datacom teams portal? I know I am not a member of the team but this could be huge for us.\n\nJohn",
            option1 = "Give Access",
            option2 = "'I don't have the permission for that.'",
            option1Result = 3,
            option2Result = 1,
            reportResult = 3,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Exciting Job Opportunity",
            emailSender = "Recruitment <recruitment@idef.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nWe came across your profile and think you'd be a great fit for our company! Click the link to view our job offer details.\nlinkedin.com/jobs/crypto-mining\n\nRegards,\nRecruitment Team",
            option1 = "'I'll check the offer.'",
            option2 = "'No thanks.'",
            option1Result = 4, 
            option2Result = 1, 
            reportResult = 1, 
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        email safeEmail14 = new email
        {
            emailTopic = "Important Policy Update: Code of Conduct",
            emailSender = "Mark Spencer <mspencer@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nWe've recently updated our company's Code of Conduct to better reflect our values and commitments. Please take a moment to review the changes and ensure compliance.\n\nThank you for your attention to this matter.\n\nRegards,\nCompliance Officer",
            option1 = "'I'll review the policy.'",
            option2 = "'Thanks for the update.'",
            option1Result = 1, // Positive response to policy update
            option2Result = 1, // Positive response to policy update
            reportResult = 3, // Neutral result for reporting a policy update
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(safeEmail14);

        blankEmail = new email
        {
            emailTopic = "[Urgent] Your Conduct",
            emailSender = "HR <hr@corp.com>",
            emailRecipients = "Steve O'Donnel, Fred Jones and Mark Robert",
            emailMessage = "Good Morning, Steve.\n\nWe have recieved a miscellaneous report about your behaviour in the office today. While the report seemed to be missing key information, we would still like to take it seriously. Could you send us your current employee record?\n\n HR",
            option1 = "REPLY",
            option2 = "'I can't do that'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "My Current Record",
            replyText = "Good Afternoon. I am not sure what may have caused the report, but I have attached the requested file. Please refer to the attachment below. Thank you.",
            sendTo1 = "CORP-HR",
            sendTo2 = "CORP-ALL",
            sendTo3 = "Fred Jones, Mart Robert",
            correctRecipient = 1,
            attachment1 = "employee_ID.png",
            attachment2 = "my-tickets_ALL.doc",
            attachment3 = "employee_record.html",
            correctAttachment = 3
        };

        eManager.emailQueue.Add(blankEmail);

        eManager.updateInbox(); //19 emails
    }
    private void loadLevelThree()
    {
        email blankEmail2 = new email
        {
            emailTopic = "New Track just Dropped!",
            emailSender = "J Tracks <tracksj@mixer.com>",
            emailRecipients = "Steve O'Donnel and 100 others",
            emailMessage = "Wsg gang,\n\n Newest track didn't do so well, but this one is sure to knock your socks off! Please give it a listen!",
            option1 = "Open the link",
            option2 = "'Please stop contacting me.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail2);

        email blankEmail = new email
        {
            emailTopic = "DataCom Floor Devices",
            emailSender = "Mark Robert <mrobert@corp.com>",
            emailRecipients = "Steve O'Donnel, Fred Jones",
            emailMessage = "Hey, Steve.\n\n Sorry but.. the machines on the Datacom floor are still a but faulty, could you continue to keep an eye on them? Sorry about that.",
            option1 = "'Got it'",
            option2 = "'Ughhh'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Account Log-In History",
            emailSender = "IT <it@corp.com>",
            emailRecipients = "Steve O'Donnel and Mark Robert",
            emailMessage = "Good Morning, Steve.\n\nDue to the issues we are having with security, we want to verify the identity of all accounts.\n\nCound you please upload an appropriate identifying image or document? Otherwise your account will be locked in a few hours for safety.\n\n IT Department",
            option1 = "REPLY",
            option2 = "'I can't do that'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "My Identification",
            replyText = "Good Morning, I have attached the an appropriate document. Please refer to the attachment below. Thank you.",
            sendTo1 = "CORP-HR",
            sendTo2 = "CORP-IT",
            sendTo3 = "Fred Jones, Mart Robert",
            correctRecipient = 2,
            attachment1 = "my_employee_ID.png",
            attachment2 = "my_internet_history.doc",
            attachment3 = "sales_records.html",
            correctAttachment = 1
        };

        eManager.emailQueue.Add(blankEmail);

        email blankEmail3 = new email
        {
            emailTopic = "[IMPORTANT] Document Scan Request",
            emailSender = "Mark Robert <mRobert@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello Steve. I left a document on your desk this morning that I would like you to scan some copies for. This will be important for a meeting we have next week with some stakeholders. Thank you.",
            option1 = "'Will do, sir'",
            option2 = "'Please refrain from contacting this email again'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "password",
            isMinigame = true
        };

        eManager.emailQueue.Add(blankEmail3);

        blankEmail = new email
        {
            emailTopic = "Confidential: Transfer Request",
            emailSender = "Greg Chapman <gchapman@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nPlease verify the transfer $5,000 to the attached account for an urgent project. I have tried contacting the rest of the datacom team but I have not recieved a response. This request is top priority and confidential, so please do not discuss it with anyone. Act swiftly.\n\nGreg Chapman",
            option1 = "Verify Transfer",
            option2 = "Forward to Line Manager",
            option1Result = 4,
            option2Result = 1,
            reportResult = 2,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Regarding the Data Breach",
            emailSender = "Mark Robert <mrobert@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Hello everyone,\n\n I know that everyone is concerned about the data breach, but let us all calm down for a moment and continue to remain professional, alright? Everything will be taken care of soon, bare with me.\n\n Mark",
            option1 = "'Alright'",
            option2 = "'Hurry up then!'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        email safeEmail11 = new email
        {
            emailTopic = "Enhance Your Workflow with a New Tool!",
            emailSender = "Jane Doe <jdoe@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Hi everyone,\n\nI hope you're doing well! I wanted to share a helpful tool with you that I've been using lately to boost productivity. It's called 'TaskMaster' and has been officially certified by our company's IT department. TaskMaster helps you organize tasks, set deadlines, and collaborate with your team seamlessly.\n\nYou can download it securely from our company's software portal:\ncorpo.com/tools/task-master\n\nLet me know if you have any questions or need assistance!\n\nBest regards,\nJane Doe",
            option1 = "'Thanks for the recommendation.'",
            option2 = "'No thanks'",
            option1Result = 1, 
            option2Result = 3, 
            reportResult = 3, 
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(safeEmail11);

        blankEmail = new email
        {
            emailTopic = "[URGENT] Emergency Update",
            emailSender = "IT <it@corb.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Dear All,\n\nDue to the recent data breach, we have implemented a quick security measure to protect our systems and your personal information. Please install the latest security update on your device:\ncorbo.com/updates/patch\n\nFailure to update may result in further security risks. Thank you for your cooperation.\n\nBest regards,\nIT Department",
            option1 = "Update System",
            option2 = "Ignore",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Remove my account from the group",
            emailSender = "Ned Parks <ned@gmail.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Hello team,\n\nI lost access to my corpo account unfortunately, could someone please remove my account from all of our team projects. Im worried about whoever is on my account getting access to them.\n\nThanks,\nNed",
            option1 = "Remove Ned's access",
            option2 = "Forward to Line Manager",
            option1Result = 3,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        email composeEmailStakeholder = new email
        {
            emailTopic = "Request for Latest Project Progress Report",
            emailSender = "Andy Waters <watersA@gmail.com>",
            emailRecipients = "CORP-DATACOM and 12 others",
            emailMessage = "Hello everyone,\n\nI hope this email finds you well. I'm writing to request the latest progress report for the Alpha project. I'm keen to stay informed about the project's developments and milestones.\n\nCould you please provide me with the most recent update at your earliest convenience? Thank you for your attention to this matter.\n\nBest regards,\nAndy",
            option1 = "REPLY",
            option2 = "'Not Available'",
            option1Result = 1, 
            option2Result = 4, 
            reportResult = 4, 
            emailType = "compose-email",
            isMinigame = true, 
            replyTitle = "Latest Project Progress Report",
            replyText = "Dear Andy,\n\nThank you for your inquiry regarding the latest progress report for Project Alpha. We appreciate your interest and support.\n\nPlease find attached the most recent progress report detailing our project's status, achievements, and upcoming milestones.\n\nShould you have any further questions or require additional information, please don't hesitate to reach out.",
            sendTo1 = "Andy Waters", 
            sendTo2 = "Randy Walgreen",
            sendTo3 = "Andy Water",
            correctRecipient = 1, 
            attachment1 = "delta_progress_report.pdf", 
            attachment2 = "alpha_progress_2024.pdf",
            attachment3 = "alpha_pitch_2024.pptx",
            correctAttachment = 2 
        };

        eManager.emailQueue.Add(composeEmailStakeholder);

        email safeEmail12 = new email
        {
            emailTopic = "Project Update: Milestone Achieved!",
            emailSender = "Karl Reading <kreading@corp.com>",
            emailRecipients = "Steve O'Donnel, Samantha Golds and 42 others",
            emailMessage = "Hi Team,\n\nI'm pleased to inform you that we've successfully achieved a major milestone in our project. Read about it here: corpo.com/projects/project-blue Congratulations to everyone for their hard work and dedication!\n\nLet's continue to work together to ensure the project's success.\n\nBest regards,\nKarl Reading",
            option1 = "'Great news!'",
            option2 = "'This is suspicious...'",
            option1Result = 1, 
            option2Result = 3,
            reportResult = 3, 
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(safeEmail12);

        email phishingImpersonationEmail = new email
        {
            emailTopic = "[IMPORTANT]",
            emailSender = "Earl Sanders <esanders@corp.com>",
            emailRecipients = "CORP-MARKETING, CORP-DATACOM",
            emailMessage = "Dear Team,\n\nI hope this email finds you well. Unfortunately, I'm writing to inform you that my corporate email account has been compromised by unauthorized access. It has come to my attention that suspicious activities have been detected in my account.\n\nAs a precautionary measure, I urge everyone to reset their passwords immediately to prevent further unauthorized access to company resources. Please click the link below to reset your password:\nspyvr.com/corpo/qowef.mal\n\nYour prompt attention to this matter is crucial to ensure the security of our corporate network.\n\nThank you for your cooperation.\n\nBest regards,\n",
            option1 = "'Will do.'",
            option2 = "'I can't do that'",
            option1Result = 4, // Neutral response for replying to the phishing email
            option2Result = 2, 
            reportResult = 1, // Positive result for reporting the phishing email
            emailType = "phishing",
            isMinigame = false
        };

        blankEmail = new email
        {
            emailTopic = "Datacom Portal Re-Access",
            emailSender = "Tim Butler <tbutler@corp.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Hello everyone,\n\nI have managed to re-gain access to my email again. IT removed all of my accounts access to the Datacom team's portal, could someone help me get in again?\n\nBest regards,\nTim",
            option1 = "'Sure'",
            option2 = "'Nope.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Immediate Password Change Required",
            emailSender = "Support <admin@corpe.com>", // Note the misspelled domain
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nDue to a recent security breach, all employees are required to change their passwords immediately. Failure to comply will result in account suspension. Please follow the link to update your credentials: secure-update.corpe.com\n\nBest Regards,\nAdmin Support",
            option1 = "Change Password",
            option2 = "'I'll do it later.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        email safeEmail14 = new email
        {
            emailTopic = "Important Policy Update: Code of Conduct",
            emailSender = "Steven Stone <compliance@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hi Steve,\n\nWe've recently updated our company's Code of Conduct to better reflect our values and commitments. Please take a moment to review the changes and ensure compliance.\n\nThank you for your attention to this matter.\n\nRegards,\nSteven",
            option1 = "Review Policy",
            option2 = "'No thanks.'",
            option1Result = 1, // Positive response to policy update
            option2Result = 3, 
            reportResult = 3, // Neutral result for reporting a policy update
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(safeEmail14);

        blankEmail = new email
        {
            emailTopic = "Share Your Login for Quick Fix",
            emailSender = "Nina Wells <nwells@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hey Steve,\n\nI'm trying to resolve an issue with our shared tool but I'm locked out. Can you share your login details so I can fix this quickly? It'll just take a minute.\n\nThanks,\nNina",
            option1 = "Share login details",
            option2 = "'Let's find a safer solution.'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Updated Job Aid",
            emailSender = "Kent Roman <kroman@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello, Steve.\n\nSince we are having major issues regarding security, I think it would be good to send the updated version of the job aid for setting up two factor authentication on work emails.\n\nYou should have access to it since Fred sent you the latest version when you were hired. Please share it to everyone. Thanks.\n\n Kent",
            option1 = "REPLY",
            option2 = "'I can't do that'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "[IMPORTANT] 2FA Job Aid",
            replyText = "Good Morning everyone,\n\n During this period, please refer to this guide for enabling two-factor authentication on company emails.\n\n Steve O'Donnel",
            sendTo1 = "CORP-HR",
            sendTo2 = "Kent Roman, Mark Robert and Fred Jones",
            sendTo3 = "CORP-ALL",
            correctRecipient = 3,
            attachment1 = "daily_sale_status.doc",
            attachment2 = "2fa_jobaid_2023.html",
            attachment3 = "2fa_jobaid_2024.html",
            correctAttachment = 3
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Incident Report",
            emailSender = "Fred Jones <fjones@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Afternoon, Steve.\n\n I have sent you a summary of the current indicent going on. Please open the file, print it off and scan some copies.\n\n Thank you,\n\n Fred",
            option1 = "'Alright'",
            option2 = "'This is suspicious'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "password",
            isMinigame = true
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Datacom Portal Re-Access",
            emailSender = "Mark Robert <mrobert@cor.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Hello team,\n\nAs we have reached the middle of the week, I would like to have everyones weekly progress report, please send it over asap!\n\nBest regards,\nMark",
            option1 = "'Sure'",
            option2 = "'Nope.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent: Update Team Contact List",
            emailSender = "Miranda Lee <mlee@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello, Steve.\n\nI've noticed that our team contact list is outdated, which could lead to issues in emergency communication. Could you please take the lead on updating this document and send the revised version to relevant departments? Make sure it includes our new hires.\n\nAppreciate your help with this,\nMiranda",
            option1 = "REPLY",
            option2 = "'I can't do that'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "Updated Team Contact List",
            replyText = "Hi Team,\n\nPlease find attached the updated team contact list, now including our new hires. Ensure you save this for your reference.\n\nBest,\nSteve O'Donnel",
            sendTo1 = "CORP-DATACOM",
            sendTo2 = "CORP-HR",
            sendTo3 = "CORP-ALL",
            correctRecipient = 1,
            attachment1 = "team_contact_list_2023.xlsx",
            attachment2 = "team_contact_list_2024.xlsx",
            attachment3 = "emergency_procedures.pdf",
            correctAttachment = 2
        };

        eManager.emailQueue.Add(blankEmail);

        eManager.updateInbox(); //20 
    }
    private void loadLevelFour()
    {
        email blankEmail = new email
        {
            emailTopic = "[IMPORTANT] Document Scan Request",
            emailSender = "Mark Robert <mRobert@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello Steve.\n\n Since there aren't many people left today, please help me with some scans. We'll have to manage a lot more things.",
            option1 = "'Will do, sir'",
            option2 = "'Please refrain from contacting this email again'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "password",
            isMinigame = true
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Formal Resignation",
            emailSender = "Alex Thompson <athompson@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "To all my colleagues,\n\nAfter careful consideration, I have decided to resign from my position at Corpo, effective two weeks from today. I have appreciated the opportunities for growth and the professional environment. I wish everyone all the best.\n\nSincerely,\nAlex Thompson",
            option1 = "'Wish you all the best, Alex.'",
            option2 = "'Meh'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Immediate Password Reset Required",
            emailSender = "IT <it@corp-helpdesk.com>", // Note the fake domain
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Due to the recent security breach, all employees are required to reset their passwords immediately. Please use the following link to reset your password: corpo-security-update.com",
            option1 = "Follow Link",
            option2 = "'I'm not sure about this..'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Share Secure Files",
            emailSender = "Hank Marvin <hmarvin@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nWith the network down, I need you to email me the client project files directly. Just attach them to a reply. It's urgent.\n\nThanks,\nHank",
            option1 = "REPLY",
            option2 = "'That's not safe.'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);


        blankEmail = new email
        {
            emailTopic = "A Message from Mark Robert",
            emailSender = "Mark Robert <mrobert@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Team,\n\nI understand that recent events have led to much concern and frustration. I want to reassure everyone that we are taking this matter seriously. While it's easy to point fingers, now is the time for unity and focus on strengthening our defenses, not assigning blame.\n\nBest,\nMark Robert",
            option1 = "'Understood, moving forward.'",
            option2 = "'More action, less talk.'",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Enough is Enough",
            emailSender = "Jamie Rivera <jrivera@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Everyone,\n\nIn light of the recent security debacle and the clear negligence on part of our leadership, I no longer wish to associate with Corpo. Effective immediately, I am resigning. Hopefully, this serves as a wake-up call. Add me on LinkedIn if you want to stay in contact: linkedin.com/jrivera \n\nJamie Rivera",
            option1 = "Add Jamie",
            option2 = "Ignore",
            option1Result = 1,
            option2Result = 2,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Verify Your Email Account Now",
            emailSender = "HR <hr@verifynow.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "We've noticed suspicious activity on your account. Please verify your account by clicking on the link below to avoid suspension: verify-youraccount-now.com",
            option1 = "Verify Account",
            option2 = "'I'll ignore this.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Drafting Resignation Notice",
            emailSender = "Diane Foster <dfoster@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nGiven the circumstances, I've decided to leave Corpo. Could you help me draft a resignation email that conveys my decision without burning bridges? I'd like to send it to my department (finance) and HR. Could you also attach the pdf version with it that I just sent?\n\nThanks,\nDiane",
            option1 = "REPLY",
            option2 = "'I'm not comfortable assisting.'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "Resignation Notice",
            replyText = "Dear Team and HR,\n\nI am writing to announce my resignation from Corpo, effective two weeks from today. I am grateful for the opportunities I've had here and wish everyone the best. Thank you for your understanding.\n\nBest,\nDiane Foster",
            sendTo1 = "CORP-DATACOM, CORP-FINANCE",
            sendTo2 = "CORP-HR",
            sendTo3 = "Diane Foster, CORP-FINANCE, CORP-HR",
            correctRecipient = 3,
            attachment1 = "company_policy.pdf",
            attachment2 = "contract_terminaiton_diane.pdf",
            attachment3 = "my_contract_agreement.pdf",
            correctAttachment = 2
        };
        
        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Weekly Data Team Meeting",
            emailSender = "Tina Gomez <tgomez@corp.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Team,\n\nJust a reminder that our weekly meeting will take place this Wednesday at 10 AM. Please be prepared to discuss your current projects and any resources you may need. Please click the link to confirm your attendance: zoom.com/RSVP-Invite \n\nBest,\nTina",
            option1 = "'Will be there.'",
            option2 = "'This is suspicious...'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Confidential: Redirect Client Payments",
            emailSender = "Fiona Grey <fgrey@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nGiven the IT issues, we're redirecting client payments to a secure account temporarily. Please see the attached instructions and proceed accordingly.\n\nFiona",
            option1 = "Follow Instructions",
            option2 = "'This seems off.'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Staying Strong Together",
            emailSender = "Elena Huerta <ehuerta@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "Dear Colleagues,\n\nThese are undoubtedly tough times for all of us at Corpo. It's in moments like these that we must remember the value of our community and the strength we have when we stand united. Let's support each other and move forward together.\n\nWarmly,\nElena",
            option1 = "'Thank you, Elena. Much needed.'",
            option2 = "'Enough of this, we're screwed.'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Action Required: Update Your Healthcare Info",
            emailSender = "HR <hr@corpo-health.com>", // Fake HR email
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Good Afternoon, Steve\n\nAs part of our new health insurance policy, all employees must update their healthcare information. You may find this information in the link below: corpo-health-update.com",
            option1 = "Update Info",
            option2 = "'Perhaps later.'",
            option1Result = 4,
            option2Result = 2,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Forward: Client List",
            emailSender = "Terry Banks <tbanks@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nI accidentally sent you the full client list. Please delete it immediately. If you've opened it, do not forward it or save copies. Apologies for this slip-up.\n\nTerry",
            option1 = "Delete Email",
            option2 = "'I've already forwarded it.'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 2,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent: Security Protocol Update",
            emailSender = "Victor Shah <vshah@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nIn response to the breach, we need to update our security protocols ASAP. Can you draft an email to inform everyone in Data and Communications about the new security measures? Include the updated security guidelines attachment.\n\nThanks,\nVictor",
            option1 = "REPLY",
            option2 = "'I'll need more details.'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "New Security Measures Implementation",
            replyText = "Dear Team,\n\nFollowing recent events, we're implementing new security measures effective immediately. Please find attached the updated security guidelines. Your compliance is mandatory and appreciated.\n\nBest,\nSteve O'Donnel",
            sendTo1 = "CORP-DATACOM",
            sendTo2 = "CORP-ALL",
            sendTo3 = "CORP-SECURITY, CORP-DATACOM",
            correctRecipient = 1,
            attachment1 = "security_guidelines_2023.pdf",
            attachment2 = "security_measures_update.pdf",
            attachment3 = "emergency_contact_list.xlsx",
            correctAttachment = 2
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Immediate Resignation",
            emailSender = "Scott Nguyen <snguyen@corp.com>",
            emailRecipients = "CORP-ALL",
            emailMessage = "To all,\n\nI am resigning from Corpo, effective immediately. Thank you for the experiences.\n\nScott Nguyen",
            option1 = "'Wish you the best, Scott.'",
            option2 = "'Just like that?'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Employee Feedback Survey",
            emailSender = "Relations <relations@corpo-survey.com>", // Fake survey email
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Dear Steve,\n\nIn light of recent events, we're conducting an employee feedback survey. Your input is crucial. Please complete the survey at the following link: corpo-feedback.com\n\nThank you",
            option1 = "Complete Survey",
            option2 = "'Im not sure.'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "More Scan Requests your way..",
            emailSender = "Mark Robert <mRobert@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hello Steve.\n\n Another document to scan for ya. I'm getting some calls from upper management about the current... situation. Ill need to provide some scans of the current state of the system.",
            option1 = "'Will do, sir'",
            option2 = "'Please refrain from contacting this email again'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "password",
            isMinigame = true
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Security Update",
            emailSender = "Gary Newman <gnewman@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nI've attached a crucial security update to combat the breach. IT has been super busy resolving tickets, so this is the best that we can do at the moment.\n\nGary",
            option1 = "Install Update",
            option2 = "'I'll wait for IT'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Draft Urgent Security Update Announcement",
            emailSender = "Bethany Cruz <bcruz@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Steve,\n\nIn the wake of the breach, we've developed a new security patch that needs to be applied by all departments immediately. Can you draft an email to notify everyone? Please attach the guideline document on how to apply the patch correctly.\n\nThanks,\nBethany",
            option1 = "REPLY",
            option2 = "'I need more details on the patch.'",
            option1Result = 1,
            option2Result = 4,
            reportResult = 4,
            emailType = "compose-email",
            isMinigame = true,
            replyTitle = "Immediate Action Required: Security Patch Update",
            replyText = "Dear everyone,\n\nA new security patch has been released to address the recent breach. It is imperative that this patch is applied across all systems without delay. Attached you will find the guidelines for the installation. Please ensure compliance by end of day.\n\nRegards,\nSteve O'Donnel",
            sendTo1 = "Bethany Cruz, CORP-DATACOM",
            sendTo2 = "CORP-ALL",
            sendTo3 = "CORP-DATACOM, CORP-SECURITY",
            correctRecipient = 2,
            attachment1 = "general_guidelines.pdf",
            attachment2 = "security_patch_guidelines.pdf",
            attachment3 = "work_from_home_policy.pdf",
            correctAttachment = 2
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Reminder: Time Tracking Compliance",
            emailSender = "Rajiv Chandra <rchandra@corp.com>",
            emailRecipients = "CORP-DATACOM",
            emailMessage = "Dear Data and Communications Team,\n\nJust a reminder to submit your time tracking sheets by EOD Friday. It's crucial for our project billing and resource management.\n\nRegards,\nRajiv",
            option1 = "Submit Sheet",
            option2 = "'Seems suspicious...'",
            option1Result = 1,
            option2Result = 3,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Urgent Assistance Needed",
            emailSender = "CEO <ceo@corpo-global.com>", // Impersonating CEO
            emailRecipients = "Steve O'Donnel",
            emailMessage = "I'm in a confidential meeting with no access to the corporate network. I need you to send me the passwords for the financial accounts. It's urgent.\n\nThanks,\nCEO",
            option1 = "Send Passwords",
            option2 = "'I need to verify this request.'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "phishing",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "Quick Fix for Email Access",
            emailSender = "Melissa Carter <mcarter@corp.com>",
            emailRecipients = "Steve O'Donnel",
            emailMessage = "Hey,\n\nI found a workaround for our email system issues. Just disable your firewall and click this link to bypass the login screen: quick-fix-corpo.com\n\nMelissa",
            option1 = "Disable Firewall",
            option2 = "'No thanks.'",
            option1Result = 4,
            option2Result = 1,
            reportResult = 1,
            emailType = "malicious",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        blankEmail = new email
        {
            emailTopic = "[IMPORTANT] Corpo Loacation 73hbI",
            emailSender = "Dominic Rust <ceo@corp.com>",
            emailRecipients = "CORP-ALL, CORP-UK, CORP-EU",
            emailMessage = "Hello everyone,\n\nI have noticed the current situation within the Corpo location within Somewhereville, UK. I apologise for not recognising this earlier, I will speak with the Corpo board and act shortly.\n\nRegards,\nDominic Rust, CEO",
            option1 = "'Thank you!'",
            option2 = "'Mark is gonna get it...'",
            option1Result = 1,
            option2Result = 1,
            reportResult = 3,
            emailType = "safe",
            isMinigame = false
        };

        eManager.emailQueue.Add(blankEmail);

        eManager.updateInbox(); //23
    }
}
