using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdownTimer : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;

    public TextMeshProUGUI timerTxt;
    public Slider timerSlider;
    public GameObject timerObject;

    private gameManager theGameManager;
   
    void Start()
    {
        //HUD Initialisation 
        timerSlider.maxValue = timeLeft;
        timerSlider.value = timeLeft;

        theGameManager = FindObjectOfType<gameManager>();
    }

    void Update()
    {
        if(timerOn)
        {
            if(timeLeft > 0)
            {
                //decrement timer
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                timeLeft = 0;
                timerOn = false;
                theGameManager.endTheGameLoss();
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerSlider.value = currentTime;
    }

    public void beginTimer()
    {
        timerOn = true;
        //timer appearing animation
        Animator startTimerAnimator = timerObject.GetComponent<Animator>();
        startTimerAnimator.SetTrigger("startedTimer");
    }

    public void stopTimer()
    {
        timerOn = false;
    }

    public void resumeTimer()
    {
        timerOn = true;
    }

}
