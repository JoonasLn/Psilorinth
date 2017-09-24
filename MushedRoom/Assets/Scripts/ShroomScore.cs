using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShroomScore : MonoBehaviour
{
    public static int score;
    public int publicScore;        

    Text text;                      

    void Awake()
    {
        text = GetComponent<Text>();

        score = 0;
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
        text.text = "Shrooms: " + score;
        publicScore = score;
    }

}
