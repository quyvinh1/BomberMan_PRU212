using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeUI;

    float remainingTime = 300f; // 5 minutes in seconds
    bool startCounter;

    // Method to start the countdown
    public void StartTimeCounter()
    {
        startCounter = true;
    }

    // Method to stop the countdown
    public void StopTimeCounter()
    {
        startCounter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startCounter && remainingTime > 0)
        {
            // Subtract the time since the last frame
            remainingTime -= Time.deltaTime;

            // Ensure remainingTime doesn't go below 0
            remainingTime = Mathf.Max(remainingTime, 0);

            // Calculate minutes and seconds
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);

            // Update the TextMeshProUGUI element
            timeUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
