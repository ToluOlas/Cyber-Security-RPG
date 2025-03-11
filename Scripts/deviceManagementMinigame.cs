using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class deviceManagementMinigame : MonoBehaviour
{
    public Slider deviceSlider;
    public Image deviceIndicator;
    public Image deviceFuctionalIndicator;

    public bool canUse;
    private bool inUse;
    public bool deviceBroken = false;

    private float breakTimer = 0f;
    public float breakInterval;
    private int breakChance;

    private int breakPercentage = 10; //chance can increase

    private float timeBroken = 0f;

    private playerController thePlayer;
    private scoreManager theScoreManager;
    private gameManager theGameManager;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerController>();
        theScoreManager = FindObjectOfType<scoreManager>();
        theGameManager = FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(theGameManager.gameStarted==false)
        {
            return;
        }

        if(Input.GetKeyUp(KeyCode.Space) && canUse == true && inUse == false && deviceBroken == true)
        {
            inUse = true;
            fixDevice();
        }

        breakTimer += Time.deltaTime;

        if(breakTimer >= breakInterval)
        {
            breakDevice();
            breakTimer = 0f;
        }

        if(deviceBroken)
        {
            timeBroken += Time.deltaTime;
        }

        if(timeBroken >= 20f)
        {
            timeBroken = 0f;
            theScoreManager.brokenDevice();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canUse = true;
            Debug.Log("Device");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canUse = false;
            Debug.Log("Leaving device");
        }
    }

    void fixDevice()
    {
        thePlayer.canMove = false;
        //show slider
        deviceSlider.gameObject.SetActive(true);
        deviceIndicator.gameObject.SetActive(false);
        //remove printer indicator
        loadingBarController theSlider = deviceSlider.GetComponent<loadingBarController>();
        theSlider.startLoading();
    }

    public void deviceFixed()
    {
        thePlayer.canMove = true;
        inUse = false;
        deviceBroken = false;
        
        breakPercentage = 0; //set percentage to 0% as a reward
        breakTimer = -10f;

        deviceSlider.gameObject.SetActive(false);
        deviceIndicator.gameObject.SetActive(false);
        deviceFuctionalIndicator.gameObject.SetActive(true);
        
    }

    private void breakDevice()
    {
        breakChance = Random.Range(0,100);
        //30% chance of a device breaking every 15 seconds
        if(breakChance<=breakPercentage && deviceBroken == false)
        {
            deviceIndicator.gameObject.SetActive(true);
            deviceFuctionalIndicator.gameObject.SetActive(false);
            deviceBroken = true;
        }
        else if(deviceBroken == false)
        {
            if(breakPercentage<30)
            {
                breakPercentage += 5;
            }     
        }
    }
    
}
