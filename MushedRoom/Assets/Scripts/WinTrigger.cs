using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour {


    void OnTriggerEnter2D(Collider co)
    {
        if (co.name == "PlayerCharacter")
            Application.LoadLevel("End Scene");
    }
}
