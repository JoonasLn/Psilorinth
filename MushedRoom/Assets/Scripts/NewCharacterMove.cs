using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterMove : MonoBehaviour
{
    public Rigidbody2D myRb;
    public float runSpeed = 10f;

    public float horAxis;
    public float verAxis;
    // Normal Movements Variables

        void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

        void FixedUpdate()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
        moveDir.y = Input.GetAxis("Vertical"); // get result of WS keys in Z
                                               // move this object at frame rate independent speed:
        transform.position += moveDir * runSpeed * Time.deltaTime;
    }

    // Move senteces

}
    
