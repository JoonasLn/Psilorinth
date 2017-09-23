using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterMove : MonoBehaviour
{
    public Rigidbody2D myRb;
    public float runSpeed = 10f;

    public float slowTime;
    public bool countSlow = false;

    public float controlFuckTime;
    public bool countFuck = false;

    public float horAxis;
    public float verAxis;
    public int reverseCon = 1;

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
        transform.position += moveDir * reverseCon * runSpeed * Time.deltaTime;
    }


    void Update()

    {
        if (countSlow == true)
        {
            slowTime -= Time.deltaTime;
            Debug.Log(slowTime);
            if (slowTime <= 0)
            {
                runSpeed = 10f;
                countSlow = false;
            }
        }

        if (countFuck == true)
        {
             controlFuckTime -= Time.deltaTime;
             if (controlFuckTime <= 0)
             {
                reverseCon = 1;
                countFuck = false;
             }
        }

    }
    public void SlowTime()
    {

        Debug.Log("Slow time");
        countSlow = true;
        runSpeed = 5f;
    }

    public void ControlFuckTime()
    {
        countFuck = true;
        reverseCon = -2; 
    }

    public void Trip()
    {
        transform.position = new Vector3 (-1, 38, -14);
    }

        

}


