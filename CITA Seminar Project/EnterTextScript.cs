using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterTextScript : MonoBehaviour
{
    //If the Player enters the Collider
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            //Enable attached Canvas
            GetComponentInChildren<Canvas>().enabled = true;
            GetComponentInChildren<Text>().text = "Press Enter";
            
        }
    }

    //If Player Exits Collider
    void OnTriggerExit2D(Collider2D col){
        if(col.tag == "Player"){
            //Disable attached Canvas
            GetComponentInChildren<Canvas>().enabled = false;
        }
    }

 
}
