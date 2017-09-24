using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour {

    public NewCharacterMove newCharacterMove;
    public Sprite sprite_l1;
    public Sprite sprite_u1;
    public Sprite sprite_d1;
    


    public Sprite currentSprite;
    // Use this for initialization
    void Start () {
        newCharacterMove = GameObject.Find("PlayerCharacter").GetComponent<NewCharacterMove>();
        currentSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update() {

        //RIGHT
        if (newCharacterMove.moveDir.x > 0.1)
        {
            
            currentSprite = sprite_l1;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            Debug.Log("here X");
        }
        //LEFT
        if (newCharacterMove.moveDir.x < -0.1)
        {
           // if (newCharacterMove.moveDir.x > newCharacterMove.moveDir.y)
            {
                currentSprite = sprite_l1;
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                Debug.Log("here -X");
            }
        }
        //UP
        if (newCharacterMove.moveDir.z > 0.1)
        {
            currentSprite = sprite_u1;
            Debug.Log("here -z");
        }
        //DOWN
        if (newCharacterMove.moveDir.z < -0.1)
        {
            currentSprite = sprite_d1;
            Debug.Log("here z");
        }
    }  
}
