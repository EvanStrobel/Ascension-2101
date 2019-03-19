using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalStuff : MonoBehaviour
{
    // UI text elements to display terminal use messages
    public GameObject LinkedObject;
    public GameObject MissKeyMessage;
    public GameObject TerminalSuccess;

    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //check if player has a key and display a message 
            if (KeyTotal.instance.keysHeld - 1 < 0)
            {
                MissKeyMessage.SetActive(true);
                // print message to console. can be removed
                print("cant operate not enough keys");
                return;
            }

            TerminalSuccess.SetActive(true);
            KeyTotal.instance.keysHeld -= 1;
            LinkedObject.SetActive(false);

            // print message to console. can be removed
            print("terminal success! Key was used.");
        }
    }

    // disable the UI text from terminal use
    void OnTriggerExit()
    {
        MissKeyMessage.SetActive(false);
        TerminalSuccess.SetActive(false);
    }
}
