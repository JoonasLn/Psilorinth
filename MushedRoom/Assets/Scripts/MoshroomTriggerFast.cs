using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class MushroomTriggerFast : MonoBehaviour
{
    public int scoreValue = 2;

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
            other.GetComponent<NewCharacterMove>().FastTime();
            Destroy(gameObject);
        }
    }
}
*/