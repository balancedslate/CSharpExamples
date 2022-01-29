using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player") {
            Debug.Log("You have picked up the Crown");
            //Destroy Game Object
            Destroy(this.gameObject, 0.01f);
            //Set World public bool to true
            FindObjectOfType<World>().hasCrown = true;
            FindObjectOfType<World>().playerSource.PlayOneShot(FindObjectOfType<World>().itemNoise);
            //TODO - Wire Cutter Item
            //TODO - Pan Flute Item
        }
    }
}
