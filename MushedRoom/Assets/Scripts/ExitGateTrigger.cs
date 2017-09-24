using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGateTrigger : MonoBehaviour
{
    public ShroomScore shroomScore;


    void OnTriggerEnter2D(Collider co)
    {
        if (GameObject.Find("ShroomScoreText").GetComponent<ShroomScore>().publicScore >= 5)
        {
            Destroy(gameObject);

        }
    }
}