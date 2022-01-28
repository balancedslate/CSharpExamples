using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void onRestart(){
        SceneManager.LoadScene("FirstRoom");
    }

    public void onQuit(){
        Destroy(GameObject.Find("WorldController"), 0.01f);
        SceneManager.LoadScene("Intro");
    }
}
