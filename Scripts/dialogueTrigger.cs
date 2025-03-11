using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public Image dialoguePrompt;
    public dialogue dialogue;

    public GameObject barricade;
    public GameObject unlockObject;

    private bool inRange = false;

    private Color greyOut = new Color(0.5f, 0.5f, 0.5f, 1f);

    public void TriggerDialogue()
    {
        dialogueBox.gameObject.SetActive(true);
        
        if(unlockObject != null)
        {
            unlockObject.gameObject.SetActive(true);
        }

        if(barricade != null)
        {
            Destroy(barricade);
        }
        FindObjectOfType<dialogueManager>().startDialogue(dialogue);
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && inRange == true && !dialogueBox.activeSelf)
        {
            //grey out dialogue prompt
            if(dialoguePrompt != null)
            {
                dialoguePrompt.color = greyOut;
            }
            
            TriggerDialogue();
            //stop npc movement
            if(gameObject.tag == "npcDialogue")
            {
                transform.parent.GetComponent<npcMovementController>().canMove = false;
            }
        }

        //check if dialogue has ended so npc can move again
        if(gameObject.tag == "npcDialogue")
        {
            if((transform.parent.GetComponent<npcMovementController>().canMove == false && !dialogueBox.activeSelf))
            {
                transform.parent.GetComponent<npcMovementController>().canMove = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(dialoguePrompt != null)
            {
                dialoguePrompt.gameObject.SetActive(true);
            }
            inRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(dialoguePrompt != null)
            {
                dialoguePrompt.gameObject.SetActive(false);
            }
            inRange = false;
        }
    }
    
}
