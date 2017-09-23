using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomTriggerTrip : MonoBehaviour
{
    public int scoreValue = 1;


    void OnTriggerEnter2D(Collider2D other)
    {
        ShroomScore.score += scoreValue;

        if (other.name == "PlayerCharacter")
        {
            //other.GetComponent<NewCharacterMove>().StartSlowTimeTimer();
            other.GetComponent<NewCharacterMove>().Trip();
            Destroy(gameObject);
        }
    }
}
