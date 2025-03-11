using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingBarController : MonoBehaviour
{
    public Slider loadingSlider;
    public float loadingDuration; 

    private void Start()
    {
        if (loadingSlider == null)
        {
            Debug.LogError("Loading Slider is not assigned!");
            return;
        }

        loadingSlider.value = 0f;
    }

    public void startLoading()
    {
        loadingSlider.value = 0f;

        StartCoroutine(fillLoadingBar());
    }

    private IEnumerator fillLoadingBar()
    {
        float elapsedTime = 0f;

        while (elapsedTime < loadingDuration)
        {
            // increment
            loadingSlider.value = Mathf.Lerp(0f, 1f, elapsedTime / loadingDuration);
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        // ensure loading bar filled at the end
        loadingSlider.value = 1f;

        
        Debug.Log("Loading complete!");

        //for computer
        if(gameObject.tag == "computerSlider")
        {
            computerController theComputer = FindObjectOfType<computerController>();
            if(theComputer.loggedIn == true)
            {
                theComputer.showTasks();
            }
            else 
            {
                theComputer.computerScreen.SetActive(false);
            }   
        }

        else if(gameObject.tag == "scannerSlider")
        {
            passwordMinigame thePasswordGame = FindObjectOfType<passwordMinigame>();
            scannerController theScanner = FindObjectOfType<scannerController>();

            thePasswordGame.minigameActive = true;

            theScanner.scannerIndicator.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }

        else if(gameObject.tag == "reconnectSlider")
        {
            systemStatus theSystemStatus = FindObjectOfType<systemStatus>();
            theSystemStatus.connectVal = 5;
            theSystemStatus.reconnectScreen.gameObject.SetActive(false);
        }

        else if(gameObject.tag == "deviceSlider")
        {
            deviceManagementMinigame[] allDevices = FindObjectsOfType<deviceManagementMinigame>();
            deviceManagementMinigame theDevice = FindActiveDevice(allDevices);

            theDevice.deviceFixed();
        }
    }

    deviceManagementMinigame FindActiveDevice(deviceManagementMinigame[] devices)
    {
        foreach(deviceManagementMinigame obj in devices)
        {
            if (obj.canUse)
            {
                return obj;
            }
        }

        return null;
    }
}
