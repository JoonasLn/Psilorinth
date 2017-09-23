using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoshroomTrigger1 : MonoBehaviour
{
    public int scoreValue = 1;

    void OnTriggerEnter2D(Collider2D co)
    {
        ShroomScore.score += scoreValue;
        if (co.name == "Character")
            Destroy(gameObject);
    }
}