using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
   Text TimeText;
   public int timer = 0;
   int zero = 0; 

   void Start()
   {
       TimeText = GetComponent<Text>();
   }
   void FixedUpdate()
   {
       if (zero == 0) 
       {
           timer++;
       }
       TimeText.text = "Time:" + timer.ToString();
   }
}