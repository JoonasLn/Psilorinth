using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCS : MonoBehaviour {

    public bool cameraRotation = false;
    public Transform targetObject;
    public float speed = 10;
    Vector3 target;
    public float cameraDist = 10;
    public float rotSpeed;
    public Vector3 orgRot;
    // Use this for initialization
    void Start()
    {
        orgRot = new Vector3(45, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        target = new Vector3(targetObject.position.x, targetObject.position.y + cameraDist, targetObject.position.z - cameraDist);
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        if (cameraRotation == true)
        {
            transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
        }
        if (cameraRotation == false)
        {
            transform.localEulerAngles = orgRot;
        }
    }

}
