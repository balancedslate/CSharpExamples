using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarMementoSwitchSix : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        GetComponentInChildren<Text>().text = "Press Enter";
    }
   //If the Player CLicks Enter in Switch One
    void OnTriggerStay2D(Collider2D col){
        if(col.tag == "Player" && Input.GetKey(KeyCode.Return)){
            //Call Public World Function
            if(FindObjectOfType<World>().warMementoSwitchOne){
                if(FindObjectOfType<World>().warMementoSwitchTwo){
                    if(FindObjectOfType<World>().warMementoSwitchThree){
                        if(FindObjectOfType<World>().warMementoSwitchFour){
                            if(FindObjectOfType<World>().warMementoSwitchFive){
                                FindObjectOfType<World>().setSixthWarMementoSwitch();
                            }
                            else{
                                FindObjectOfType<World>().clearWarMementoSwitches();
                                GetComponentInChildren<Text>().text = "Wrong Order. Try Again.";
                            }
                        }
                        else{
                            FindObjectOfType<World>().clearWarMementoSwitches();
                            GetComponentInChildren<Text>().text = "Wrong Order. Try Again.";
                        }
                    }
                    else{
                        FindObjectOfType<World>().clearWarMementoSwitches();
                        GetComponentInChildren<Text>().text = "Wrong Order. Try Again.";
                    }
                            
                }
                else{
                    FindObjectOfType<World>().clearWarMementoSwitches();
                    GetComponentInChildren<Text>().text = "Wrong Order. Try Again.";
                }
            }
            else{
                FindObjectOfType<World>().clearWarMementoSwitches();
                GetComponentInChildren<Text>().text = "Wrong Order. Try Again.";
            }
        }
    }
}
