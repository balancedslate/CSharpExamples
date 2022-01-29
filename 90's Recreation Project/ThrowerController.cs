using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator throwerA;
    public bool isThrowing;
    public int time = 0;
    public GameObject knife;
    GameObject clone;
    int health = 2;
    void Start()
    {
        throwerA = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        thrower();
    }
    void thrower()
    {
        throwerA.SetBool("IsThrowing", true);
        if (isThrowing == true)
        {
            clone = Instantiate(knife, gameObject.transform);
        }
    }
    public void Die()
    {
        health--;
        if(health == 0)
        {
            Destroy(gameObject);
        }
        
    }
}
