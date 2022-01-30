using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

public float timeValue;
public Text timeText;

void Start() {
    timeValue = 121f;
}

    // Update is called once per frame
    void Update() {
        if (timeValue > 0) {
            timeValue -= Time.deltaTime;
        } else {
            timeValue = 0;
        }

        displayTime(timeValue);
    }

    void displayTime(float time) {
        if(time < 0) {
            time = 0;
        }

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
