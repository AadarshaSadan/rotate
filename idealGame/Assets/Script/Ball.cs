using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ball : MonoBehaviour
{
    //private GameObject[] spwanpoint;
    public GameObject Ball_prefab;
    GameObject ballclone;
    Vector3 newobject;
    GameObject clone;
    private bool isBall;


    private void Start()
    {
        //ballclone = Instantiate(Ball_prefab, transform.position, transform.rotation) as GameObject;
        Vector3 position = new Vector3(Random.Range(-1.3546F, 1.83F), Random.Range(-0.067955f, 0.52F), Random.Range(-4.8F, 1.84F));
        
        clone = Instantiate(Ball_prefab, transform.position, Quaternion.identity) as GameObject;

    }

    public void TimetoGenerateNewball()
    {


        // ballclone = Instantiate(Ball_prefab, transform.position, transform.rotation) as GameObject;
        //clone = Instantiate(Ball_prefab, transform.position, Quaternion.identity) as GameObject;

        

    }
    
}
