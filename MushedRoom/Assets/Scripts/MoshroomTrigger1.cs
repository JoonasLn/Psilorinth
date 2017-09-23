using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoshroomTrigger1 : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Character")
            Destroy(gameObject);
    }
}