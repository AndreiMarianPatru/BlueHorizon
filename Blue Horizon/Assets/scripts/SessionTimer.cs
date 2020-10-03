using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionTimer : MonoBehaviour
{
    private static SessionTimer SessionTimerinstance;

    //Counter of whole session time
    private Double Timer = 0.0f;

    //Ensure only one session timer exists
    private void Awake()
    {
        //Destroy if already exists
        if (SessionTimerinstance && SessionTimerinstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            SessionTimerinstance = this;
        }

        //Keep alive over multiple scenes
        DontDestroyOnLoad(gameObject);
    }

    //Increment timer
    private void Update()
    {
        Timer += Time.deltaTime;
        //Debug.Log("Session length: " + ConvertSecondsToTime(Timer));
    }

    //Export the session length to the analytics
    private void OnApplicationQuit()
    {
        AnalyticsExport.SendToExport("Session length: " + ConvertSecondsToTime(Timer));
    }

    //Convert seconds to: hours, minutes, seconds, miliseconds
    public static string ConvertSecondsToTime(Double Seconds)
    {
        return TimeSpan.FromSeconds(Seconds).ToString(@"hh\:mm\:ss\:fff");
    }
}
