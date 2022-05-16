using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerController : MonoBehaviour
{
    // Start is called before the first frame update
    public static TimerController instance;
    public TextMeshPro timeCounter;
    private TimeSpan timePlaying;
    private bool timerGoing;
    private float timeElapsed;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {

        timerGoing = false;
    }
    public void BeginTimer()
    {
        timeCounter.text = "Time: 00:00.00";
        timerGoing = true;
        timeElapsed = 0f;
        StartCoroutine(UpdateTimer());
    }
    public void EndTimer()
    {
        timerGoing = false;
    }
    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            timeElapsed += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timeElapsed);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;
            yield return null;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
