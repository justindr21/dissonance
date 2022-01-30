using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeStart = 3f;
    public float time = 0f;
    public GameObject timer;

    public Text timeText;

    // Update is called once per frame
   
   void Start() {
       time = timeStart;
   }
   
    void Update() {
        time -= 1 * Time.deltaTime;
        timeText.text = time.ToString("0");

        if(time < 0) {
            timeText.text = "Go!";
            time = 0;
            timer.SetActive(true);
            this.enabled = false;
        }
    }
}
