using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour {
    public Transform targetObject;
    public float speed = 10;
    Vector3 target;
    public float aboveHeight = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        target = new Vector3(targetObject.position.x, targetObject.position.y + aboveHeight , targetObject.position.z);
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
