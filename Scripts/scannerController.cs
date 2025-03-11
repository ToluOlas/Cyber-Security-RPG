using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scannerController : MonoBehaviour
{
    public Slider scannerSlider;
    public Image scannerIndicator;
    public GameObject scannerUI;

    public List<int> password = new List<int>();
    private int passwordLength;
    public GameObject startScanButton;

    //positioning of password inputs
    public GameObject passKey1;
    public GameObject passKey2;
    public GameObject passKey3;
    public GameObject passKey4;
    public GameObject passKey5;
    public GameObject passKey6;

    //passwork keys
    public GameObject redCircle;
    public GameObject redDiamond;
    public GameObject redHeart;
    public GameObject blueCircle;
    public GameObject blueDiamond;
    public GameObject blueHeart;
    public GameObject greenCircle;
    public GameObject greenDiamond;
    public GameObject greenHeart;

    private GameObject newKey;

    private bool canInteract;
    public bool isScanning;

    private playerController thePlayer;
    private passwordMinigame passwordGame;

    void OnEnable()
    {
        canInteract = false;
        isScanning = false;
        scannerIndicator.gameObject.SetActive(true);
        scannerSlider.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerController>();
        passwordGame = FindObjectOfType<passwordMinigame>();
    }

    // Update is called once per frame
    void Update()
    {
        if(passwordGame.minigameActive)
        {
            return;
        }
        if(Input.GetKeyUp(KeyCode.Space) && canInteract == true && isScanning == false)
        {
            //display scanner UI
            scannerUI.gameObject.SetActive(true);
            thePlayer.canMove = false;  
        }

        passwordLength = password.Count;

        if(passwordLength>0)
        {
            startScanButton.gameObject.SetActive(true);
        }
        else
        {
            startScanButton.gameObject.SetActive(false); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = true;
            Debug.Log("In scanning range...");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = false;
            Debug.Log("Leaving scanner...");
        }
    }

    //9 symbols for passwords
    public void addSymbol(int symbolNumber)
    {
        if(passwordLength>=6)
        {
            return;
        }
        
        switch (symbolNumber)
        {
            case 1:
                //red circle
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(redCircle, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(redCircle, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(redCircle, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(redCircle, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(redCircle, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(redCircle, passKey6.transform);
                        break; 
                }
                break;
            case 2:
                //red diamond
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(redDiamond, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(redDiamond, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(redDiamond, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(redDiamond, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(redDiamond, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(redDiamond, passKey6.transform);
                        break; 
                }
                break;
            case 3:
                //red heart
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(redHeart, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(redHeart, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(redHeart, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(redHeart, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(redHeart, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(redHeart, passKey6.transform);
                        break; 
                }
                break;
            case 4:
                //blue circle
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(blueCircle, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(blueCircle, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(blueCircle, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(blueCircle, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(blueCircle, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(blueCircle, passKey6.transform);
                        break; 
                }
                break;
            case 5:
                //blue diamond
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(blueDiamond, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(blueDiamond, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(blueDiamond, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(blueDiamond, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(blueDiamond, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(blueDiamond, passKey6.transform);
                        break; 
                }
                break;
            case 6:
                //blue heart
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(blueHeart, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(blueHeart, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(blueHeart, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(blueHeart, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(blueHeart, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(blueHeart, passKey6.transform);
                        break; 
                }
                break;
            case 7:
                //green circle
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(greenCircle, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(greenCircle, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(greenCircle, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(greenCircle, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(greenCircle, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(greenCircle, passKey6.transform);
                        break; 
                }
                break;
            case 8:
                //green diamond
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(greenDiamond, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(greenDiamond, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(greenDiamond, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(greenDiamond, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(greenDiamond, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(greenDiamond, passKey6.transform);
                        break; 
                }
                break;
            case 9:
                //green heart
                switch (passwordLength)
                {
                    case 0:
                        newKey = Instantiate(greenHeart, passKey1.transform);
                        break;
                    case 1:
                        newKey = Instantiate(greenHeart, passKey2.transform);
                        break;
                    case 2:
                        newKey = Instantiate(greenHeart, passKey3.transform);
                        break;
                    case 3:
                        newKey = Instantiate(greenHeart, passKey4.transform);
                        break;
                    case 4:
                        newKey = Instantiate(greenHeart, passKey5.transform);
                        break;
                    case 5:
                        newKey = Instantiate(greenHeart, passKey6.transform);
                        break; 
                }
                break;
        }

        password.Add(symbolNumber);
    }

    public void resetPassword()
    {
        password = new List<int>();
        clearDisplay();
    }

    public void clearDisplay()
    {
        GameObject[] currentKeys = GameObject.FindGameObjectsWithTag("password");

        // Destroy each object in the array
        foreach (GameObject obj in currentKeys)
        {
            Destroy(obj); // or use DestroyImmediate(obj) if needed
        }
    }

    public void startScanning()
    {
        clearDisplay();
        isScanning = true;
        //show slider
        scannerSlider.gameObject.SetActive(true);
        //remove scanner indicator
        scannerIndicator.gameObject.SetActive(false);
        
        loadingBarController theSlider = scannerSlider.GetComponent<loadingBarController>();
        theSlider.startLoading();
        //save password
        //deactivate scanner canvas / close scanner UI
        closeScanner();
    }

    public void closeScanner()
    {
        scannerUI.gameObject.SetActive(false);
        thePlayer.canMove = true;
    }
}
