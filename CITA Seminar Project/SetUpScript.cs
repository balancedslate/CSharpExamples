using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetUpScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update(){
        FinishScene();
    }
    void FinishScene(){
        if(SceneManager.GetActiveScene().name == "SetUp"){
            SceneManager.LoadScene("FirstRoom");
        }
        if(SceneManager.GetActiveScene().name == "WarMemento"){
            SceneManager.LoadScene("MementoRoom");
        }
        if(SceneManager.GetActiveScene().name == "FamineMemento"){
            SceneManager.LoadScene("ScienceRoom");
        }
        if(SceneManager.GetActiveScene().name == "ConquestMemento"){
            SceneManager.LoadScene("Credits");
        }
   }

}
