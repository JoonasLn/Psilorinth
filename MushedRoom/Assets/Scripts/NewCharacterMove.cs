using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterMove : MonoBehaviour
{
    public Rigidbody2D myRb;
    public float runSpeed = 10f;

    public float slowTime = 5f;
    public bool countSlow = false;

    public float controlFuckTime = 5f;
    public bool countFuck = false;

    public bool countCamRot = false;
    public float camRotTime = 5f;
    public Camera myCamera;
    public float rotSpeed = 10;
    public Vector3 orgRot;

    public float horAxis;
    public float verAxis;
    public int reverseCon = 1;

    // Normal Movements Variables

    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        myCamera = Camera.main;
        orgRot = new Vector3(45, 0, 0);
    }

    void FixedUpdate()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
        moveDir.y = Input.GetAxis("Vertical"); // get result of WS keys in Z
                                               // move this object at frame rate independent speed:
        transform.position += moveDir * reverseCon * runSpeed * Time.deltaTime;

    }

    // Move senteces

    void Update()

    {
        if (countCamRot == true)
        {
            camRotTime -= Time.deltaTime;
            Debug.Log(camRotTime);
            myCamera.transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
            if (camRotTime <= 0)
            {
                countCamRot = false;
                myCamera.transform.localEulerAngles = orgRot;
            }
        }
        else if (countSlow == true)
        {
            slowTime -= Time.deltaTime;
            Debug.Log(slowTime);
            if (slowTime <= 0)
            {
                runSpeed = 10f;
                countSlow = false;
            }
        }

        else if (countFuck == true)
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
        reverseCon = -1; 
    }

    public void CamRot()
    {
        Debug.Log("Slow time");
        countCamRot = true;
    }

    public void Trip()
    {
        transform.position = new Vector3 (-1, 38, -14);
    }

        

}


