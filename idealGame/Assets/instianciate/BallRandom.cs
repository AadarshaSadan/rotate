using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRandom : MonoBehaviour {
    public Transform prefab;
    private float mindistance=1.4f;
    private float maxdistance=2.82f;
    //private Rigidbody rb;
	// Use this for initialization
	void Start () {
        Physics.gravity=new Vector3(0f, -9.81f, 0f);
        float X_postion = Random.Range(-4.0f, 4.0f);
        float Z_position = Random.Range(-4.0f, 4.0f);
        Debug.Log(X_postion);
        Debug.Log(Z_position);
        Vector3 position = new Vector3(X_postion, 0.51f, Z_position);
        // transform.position = Random.insideUnitCircle * 5;
        Instantiate(prefab, position, Quaternion.identity);



    }
	
	// Update is called once per frame
	void Update () {


        
        // float objectPostion=new

        if (Input.GetMouseButtonDown(0))
        {
            float X_postion = Random.Range(-4.0f, 4.0f);
            float Z_position = Random.Range(-4.0f, 4.0f);

            Debug.Log(X_postion);
            Debug.Log(Z_position);
            Vector3 position = new Vector3(X_postion, 5, Z_position);
            // transform.position = Random.insideUnitCircle * 5;
            Instantiate(prefab, position, Quaternion.identity);
            // transform.position = Random;
        }
        }

    

}
