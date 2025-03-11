using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class passwordMinigame : MonoBehaviour
{
    private List<int> realPassword;

    private List<int> enteredPassword = new List<int>();
    private int passwordLength;

    private scannerController theScanner;
    private playerController thePlayer;
    private scoreManager theScore;
    
    public bool minigameActive;
    private bool canInteract;

    public GameObject passwordVerifyScreen;

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

    private int numberOfTries;
    // Start is called before the first frame update

    void Start()
    {
        theScanner = FindObjectOfType<scannerController>();
        thePlayer = FindObjectOfType<playerController>();
        theScore = FindObjectOfType<scoreManager>();

        minigameActive = false;
        canInteract = false;
        numberOfTries = 3;
    }

    // Update is called once per frame
    void Update()
    {
        realPassword = theScanner.password;

        if(Input.GetKeyUp(KeyCode.Space) && minigameActive == true && canInteract == true)
        {
            Debug.Log("Working!!!");
            passwordVerifyScreen.gameObject.SetActive(true);
            canInteract = false;
            thePlayer.canMove = false;
        }

        passwordLength = enteredPassword.Count;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = true;
            Debug.Log("Enter Password?");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = false;
            Debug.Log("Nvm...");
        }
    }

    //9 symbols for passwords
    // 1 - Red Circle / 2 - Red Diamond / 3 - Red Heart
    // 4 - Blue Circle / 5 - Blue Diamond / 6 - Blue Heart
    // 7 - Green Circle / 8 - Green Diamond / 9 - Green Heart
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

        enteredPassword.Add(symbolNumber);
    }

    public void resetPassword()
    {
        enteredPassword = new List<int>();

        GameObject[] currentKeys = GameObject.FindGameObjectsWithTag("password");

        // Destroy each object in the array
        foreach (GameObject obj in currentKeys)
        {
            Destroy(obj); // or use DestroyImmediate(obj) if needed
        }
    }

    public void authorisePassword()
    {
        if(enteredPassword.SequenceEqual(realPassword))
        {
            Debug.Log("Password Correct");
            thePlayer.canMove = true;
            theScore.passwordMinigameResult(true, numberOfTries, isPasswordStrong());
            resetMinigame();
        }
        else 
        {
            Debug.Log("Password Incorrect");
            numberOfTries = numberOfTries - 1;

            resetPassword();
            
            if(numberOfTries == 0)
            {
                theScore.passwordMinigameResult(false, numberOfTries, isPasswordStrong());
                resetMinigame();
                thePlayer.canMove = true;
            }

        }
    }

    public void resetMinigame()
    {
        minigameActive = false;
        numberOfTries = 3;
        
        Debug.Log("Lol lmao");
        resetPassword();
        theScanner.resetPassword();
        theScanner.clearDisplay();

        passwordVerifyScreen.gameObject.SetActive(false);
        gameObject.SetActive(false);
        theScanner.gameObject.SetActive(false);
    }

    public void closeScanner()
    {
        passwordVerifyScreen.gameObject.SetActive(false);
        thePlayer.canMove = true;
    }

    private bool isPasswordStrong()
    {
        if (realPassword.Count <=3)
        {
            return false;
        }
        else if(colourCount(realPassword)<=1)
        {
            return false;
        }
        else if(shapeCount(realPassword)<=1)
        {
            return false;
        }

        else if(isSimpleSequence(realPassword))
        {
            return false;
        }
        else
        {
            return true;
        }


    }

    private int colourCount(List<int> password)
    {
        bool redFound = false;
        bool blueFound = false;
        bool greenFound = false;

        int coloursTotal = 0;

        foreach (int number in password)
        {
            if ((number == 1 || number == 2 || number == 3) && redFound == false)
            {
                redFound = true;
                coloursTotal = coloursTotal + 1;
            }
            else if ((number == 4 || number == 5 || number == 6) && blueFound == false)
            {
                blueFound = true;
                coloursTotal = coloursTotal + 1;
            }
            else if ((number == 7 || number == 8 || number == 9) && greenFound == false)
            {
                greenFound = true;
                coloursTotal = coloursTotal + 1;
            }
        }

        return coloursTotal;
    }

    private int shapeCount(List<int> password)
    {
        bool circleFound = false;
        bool diamondFound = false;
        bool heartFound = false;

        int shapesTotal = 0;

        foreach (int number in password)
        {
            if ((number == 1 || number == 4 || number == 7) && circleFound == false)
            {
                circleFound = true;
                shapesTotal = shapesTotal + 1;
            }
            else if ((number == 2 || number == 5 || number == 8) && diamondFound == false)
            {
                diamondFound = true;
                shapesTotal = shapesTotal + 1;
            }
            else if ((number == 3 || number == 6 || number == 9) && heartFound == false)
            {
                heartFound = true;
                shapesTotal = shapesTotal + 1;
            }
        }

        return shapesTotal;
    }

    private bool isSimpleSequence(List<int> password)
    {
        // Check if the password is a simple sequence of numbers
        for (int i = 0; i < password.Count - 1; i++)
        {
            if (password[i] + 1 != password[i + 1])
            {
               return false;
            }
        }
        return true;
    }
}
