using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomTriggerSlow : MonoBehaviour
{
    public int scoreValue = 1;

    //public LevelManagerCS levelManager;

    void Awake()
    {
        //levelManager = GameObject.Find("LevelManager").GetComponent<LevelManagerCS>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Is triggered");
        ShroomScore.score += scoreValue;

        if (other.name == "PlayerCharacter")
        {
            //other.GetComponent<NewCharacterMove>().StartSlowTimeTimer();
            other.GetComponent<NewCharacterMove>().SlowTime();
            Destroy(gameObject);
        }
    }
}
