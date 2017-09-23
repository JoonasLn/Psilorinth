using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerOLD : MonoBehaviour
{
    public float roundTime = 300;
    private Text timerText;

    void Start ()
    {
        timerText = GetComponent<Text>();
	}
	
	void Update ()
    {
        roundTime -= Time.deltaTime;
        timerText.text = roundTime.ToString("f0");

        if (roundTime <= 0)
        {
            Application.LoadLevel("End Scene");
        }
	}
}
