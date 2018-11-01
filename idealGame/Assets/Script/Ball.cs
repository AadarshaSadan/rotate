using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ball : MonoBehaviour
{
    //private GameObject[] spwanpoint;
    public GameObject Ball_prefab;
     GameObject ballclone;


    private void Start()
    {
        ballclone = Instantiate(Ball_prefab, transform.position, transform.rotation) as GameObject;
    }

    public void TimetoGenerateNewball()
    {

      
      ballclone = Instantiate(Ball_prefab, transform.position, transform.rotation) as GameObject;
        
    }
    
}
