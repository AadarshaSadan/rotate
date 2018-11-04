using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientation : MonoBehaviour {

    public bool isFlat = true;
    private Rigidbody rigid;
    float speed = 0.4445f;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 tilt = Input.acceleration;
        rigid.AddForce(tilt.x,0,tilt.y*speed);
	}
}
