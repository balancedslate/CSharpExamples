using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FamineVatScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        GetComponentInChildren<Text>().text = "Press Enter";
    }

    void OnTriggerStay2D(Collider2D col){
        if(Input.GetKeyDown(KeyCode.Return)){
            //Call Public World Function
           FindObjectOfType<World>().placeColor();
           if(FindObjectOfType<World>().isFailed){
               GetComponentInChildren<Text>().text = "Incorrect Chemicals. Please Re-try.";
           }
        }
    }
}
