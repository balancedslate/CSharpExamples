using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isDragonFinished = false;
    int time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isDragonFinished == true)
        {
            Die();
        }
        time++;
        if (time % 300 == 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
