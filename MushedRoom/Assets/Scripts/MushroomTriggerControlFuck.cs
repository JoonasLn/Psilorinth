using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomTriggerControlFuck : MonoBehaviour
{
    public int scoreValue = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Is triggered");
        ShroomScore.score += scoreValue;

        if (other.name == "PlayerCharacter")
        {
            //other.GetComponent<NewCharacterMove>().StartSlowTimeTimer();
            other.GetComponent<NewCharacterMove>().ControlFuckTime();
            Destroy(gameObject);
        }
    }
}