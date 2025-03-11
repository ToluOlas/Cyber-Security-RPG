using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class systemStatus : MonoBehaviour
{
    public TextMeshProUGUI wifiStrength;
    public TextMeshProUGUI currentNetwork;
    public Image wifiIcon;
    public GameObject reconnectScreen;
    public Slider reconnectSlider;

    public Image wifiHUDIcon;

    private float shiftTimer = 0f;
    public float shiftInterval = 7f;
    private int shiftChance;

    private float timeVulnerable = 0f;

    public int connectVal;

    private scoreManager theScoreManager;
    private gameManager theGameManager;


    // Start is called before the first frame update
    void Start()
    {
        connectVal = 4;
        theScoreManager = FindObjectOfType<scoreManager>();
        theGameManager = FindObjectOfType<gameManager>();

        wifiHUDIcon.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if(theGameManager.gameStarted==false)
        {
            return;
        }

        shiftTimer += Time.deltaTime;

        if(shiftTimer >= shiftInterval)
        {
            wifiShift();
            shiftTimer = 0f;
        }
        //check conenction value
        switch(connectVal)
        {
            case 5:
                wifiStrength.text = "Wifi Connection: SECURED";
                wifiStrength.color = Color.blue;
                currentNetwork.text = "CORPO-NETWORK Private";

                wifiIcon.color = Color.blue;
                wifiHUDIcon.color = Color.green;
                break;
            case 4:
                wifiStrength.text = "Wifi Connection: Strong";
                wifiStrength.color = Color.blue;
                currentNetwork.text = "CORPO-NETWORK Private";

                wifiIcon.color = Color.blue;
                wifiHUDIcon.color = Color.green;
                break;
            case 3:
                wifiStrength.text = "Wifi Connection: Good";
                wifiStrength.color = Color.green;

                wifiIcon.color = Color.green;
                break;
            case 2:
                wifiStrength.text = "Wifi Connection: Fair";
                wifiStrength.color = Color.yellow;

                wifiIcon.color = Color.yellow;
                break;
            case 1:
                wifiStrength.text = "Wifi Connection: Poor";
                wifiStrength.color = Color.red;

                wifiIcon.color = Color.red;
                wifiHUDIcon.color = Color.red;
                break;
            case 0:
                wifiStrength.text = "Wifi Connection: ???";
                wifiStrength.color = Color.green;
                currentNetwork.text = "STREET-WIFI Unsecure";

                wifiIcon.color = Color.green;

                timeVulnerable += Time.deltaTime;
                break;
        }

        if(timeVulnerable >= 20f)
        {
            timeVulnerable = 0f;
            theScoreManager.badConnection();
        }
    }

    private void wifiShift()
    {
        shiftChance = Random.Range(0,100);
        //check conenction value
        switch(connectVal)
        {
            case 5://100% chance of going down, grace period after reconnecting
                connectVal -= 1;
                break;

            case 4://50% chance of staying, 50% chance of going down
                if (shiftChance <= 49)
                {
                    //no change
                }
                else
                {
                    connectVal -= 1;
                }              
                break;

            case 3://40% chance of staying, 30% chance of going up, 30% chance of going down
                if (shiftChance <= 39)
                {
                    //no change
                }
                else if(shiftChance >= 40 && shiftChance <= 69)
                {
                    connectVal += 1;
                }
                else if(shiftChance >= 70)
                {
                    connectVal -= 1;
                }               
                break;

            case 2://25% chance of staying, 25% chance of going up, 50% chance of going down
                if (shiftChance <= 24)
                {
                    //no change
                }
                else if(shiftChance >= 25 && shiftChance <= 49)
                {
                    connectVal += 1;
                }
                else if(shiftChance>=50)
                {
                    connectVal -= 1;
                }               
                break;

            case 1://100% chance of going down
                connectVal -= 1;              
                break;

            case 0:
                Debug.Log("Unstable Network.");
                break;
        }
    }

    public void reconnectToCorp()
    {
        reconnectScreen.SetActive(true);
        loadingBarController theSlider = reconnectSlider.GetComponent<loadingBarController>();
        theSlider.startLoading();
    }
}
