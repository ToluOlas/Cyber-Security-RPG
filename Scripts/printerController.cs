using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class printerController : MonoBehaviour
{
    // Start is called before the first frame update
    
    //printer HUD
    public Slider printerSlider;
    public Image printerIndicator;

    private bool canPrint;
    public bool isPrinting;

    void Awake()
    {
        canPrint = false;
        isPrinting = false;
        printerIndicator.gameObject.SetActive(true);
        printerSlider.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && canPrint == true && isPrinting == false)
        {
            isPrinting = true;
            print();
        }

        if(printerSlider.value == 1f)
        {
            isPrinting = false;
            //prepare for document collection
            printerSlider.value = 0f;
            printerSlider.gameObject.SetActive(false);
            printerIndicator.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canPrint = true;
            Debug.Log("In printing range...");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canPrint = false;
            Debug.Log("Leaving printer...");
        }
    }

    public void print()
    {
        //show slider
        printerSlider.gameObject.SetActive(true);
        printerIndicator.gameObject.SetActive(false);
        //remove printer indicator
        loadingBarController theSlider = printerSlider.GetComponent<loadingBarController>();
        theSlider.startLoading();
    }
}
