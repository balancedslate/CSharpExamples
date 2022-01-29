using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaminePuzzleScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D col){
        if(col.tag == "Player" && Input.GetKeyDown(KeyCode.Return)){
            //Call Public World Function
            FindObjectOfType<World>().SelectColor(this.tag);
            Debug.Log("You've Selected a Color");
        }
    }
}
