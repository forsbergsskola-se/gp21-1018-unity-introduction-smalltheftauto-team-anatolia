using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerEU : MonoBehaviour
{
    public float TimeValue = 90;
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        if (TimeValue > 0)          //You can lock the time value to 0
        {
            TimeValue -= Time.deltaTime;
        }
        else
        {
            TimeValue = 0;      //you can make a repeating timer by adding timevalue += 90;
        }
        DisplayTime(TimeValue);
       
    }

    void DisplayTime(float timetoDisplay)       // Here is code where its going to show the timer on screen.
    {
        if (TimeValue < 0)          // checking if the timer is below 0 then lock it if its not below 0.
        {
            timetoDisplay = 0;
        }
    
        float minutes = Mathf.FloorToInt(timetoDisplay / 60);           // made a minutes by dividing it
                                                                        // //MathF is a collection of math functions
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);
    
        timeText.text = string.Format(("{0:00}:{1:00}"), minutes, seconds); //the first values represents minutes, and the : is just : and the second value represents seconds.
    
    
    }
}
