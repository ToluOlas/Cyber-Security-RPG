using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueStepTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public dialogue dialogue;

    public GameObject barricade;
    public GameObject unlockObject;

    public bool isStartDialogue;

    private bool hasActivated = false;

    void Start()
    {

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<dialogueManager>().startDialogue(dialogue); //line 26
        Debug.Log("TEST3");

        if(barricade != null)
        {
            Destroy(barricade);
        }

        if(unlockObject != null)
        {
            unlockObject.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        if(isStartDialogue)
        {
            isStartDialogue = false;
            dialogueBox.gameObject.SetActive(true);
            TriggerDialogue(); //line 19
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && hasActivated == false)
        {
            dialogueBox.gameObject.SetActive(true);
            TriggerDialogue();
            hasActivated = true;
        }
    }
}
