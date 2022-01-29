using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanFluteScript : MonoBehaviour
{
    // Call Set Pan Flute
    void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player") {
            Debug.Log("You have picked up the Pan Flute");
            //Destroy Game Object
            Destroy(this.gameObject, 0.01f);
            //Set World public bool to true
            FindObjectOfType<World>().setPanFlute();
        }
    }
}
