using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class deviceManagementCounter : MonoBehaviour
{
    public TextMeshProUGUI brokenDeviceTally;
    private int numberBroken;

    private deviceManagementMinigame[] allDevices;
    // Start is called before the first frame update
    void Start()
    {
        allDevices = FindObjectsOfType<deviceManagementMinigame>();
    }

    // Update is called once per frame
    void Update()
    {
        numberBroken = findBrokenDevices();

        brokenDeviceTally.text = numberBroken.ToString();

        if(numberBroken <= 0)
        {
            brokenDeviceTally.color = Color.green;
        }
        else if(numberBroken > 0)
        {
            brokenDeviceTally.color = Color.red;
        }
    }

    private int findBrokenDevices()
    {
        int objTotal = 0;
        foreach(deviceManagementMinigame obj in allDevices)
        {
            if (obj.deviceBroken)
            {
                objTotal += 1;
            }
        }

        return objTotal;
    }
}
