﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
  //  public SceneHandler SceneHandler;
    public GameEvent CountdownEndScreen;
    public float CountdownValue;
    public Text CountdownText;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    void Update()
    {
        if (!GameTimeHandler.GameIsPaused)
        {
            CountdownText.text = Mathf.Floor(CountdownValue / 60).ToString("00") + ":" + Mathf.FloorToInt(CountdownValue % 60).ToString("00"); // Display countdown

            if (CountdownValue <= 0) OnCountdownEnd(); // If countdown ended call onCountdownEnd function
        }

    }

    public IEnumerator StartCountdown()
    {
        while (CountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f); // Scale timer
            CountdownValue--; // Reduce timer
        }
    }

    void OnCountdownEnd()
    {
        CountdownEndScreen.Raise();
    }
}
