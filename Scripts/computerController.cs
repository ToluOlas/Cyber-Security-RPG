using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class computerController : MonoBehaviour
{
    public GameObject computerScreen;
    public bool loggedIn;

    public Slider loginSlider;

    //individual screens
    public GameObject loadingScreen;
    public GameObject emailScreen;
    public GameObject taskListScreen;
    public GameObject systemScreen;

    public openPC thePC;

    private playerController thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        loggedIn = false;

        thePlayer = FindObjectOfType<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startComputer()
    {
        //set up tasks
        logIn();
        //tasks animation
    }

    public void logIn()
    {
        thePlayer.canMove = false;
        loggedIn = true;
        thePC.pcOpen = true;
        computerScreen.SetActive(true);
        loadingScreen.SetActive(true);
        //play log in slider
        loadingBarController theSlider = loginSlider.GetComponent<loadingBarController>();
        theSlider.startLoading();
        
        //set active true
    }

    public void logOut()
    {
        //deactivate all other screens
        emailScreen.SetActive(false);
        taskListScreen.SetActive(false);
        systemScreen.SetActive(false);
        emailManager theEmail = FindObjectOfType<emailManager>();
        theEmail.replyGraphic.SetActive(false);
        theEmail.emailBodyGraphic.SetActive(false);
        

        thePlayer.canMove = true;
        loggedIn = false; //only logging out sets this to false
        thePC.pcOpen = false;

        //play log out slider
        loadingBarController theSlider = loginSlider.GetComponent<loadingBarController>();
        theSlider.startLoading();
    }

    public void forceStart()
    {
        thePlayer.canMove = false;
        thePC.pcOpen = true;
        computerScreen.SetActive(true);
        showTasks();
    }
    public void forceClose()
    {
        thePlayer.canMove = true;
        computerScreen.SetActive(false);
        thePC.pcOpen = false;
    }

    public void showTasks()
    {
        //deactivate any other screens
        emailScreen.SetActive(false);
        systemScreen.SetActive(false);
        //activate tasks page
        taskListScreen.SetActive(true);
    }

    public void showEmail()
    {
        //deactivate any other screens
        taskListScreen.SetActive(false);
        systemScreen.SetActive(false);
        //activate email page
        emailScreen.SetActive(true);
    }

    public void showSystem()
    {
        taskListScreen.SetActive(false);
        emailScreen.SetActive(false);
        //actvate system info page
        systemScreen.SetActive(true);
    }
}
