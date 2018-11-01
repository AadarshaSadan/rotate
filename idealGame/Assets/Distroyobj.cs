using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Distroyobj : MonoBehaviour
{
    public bool isDestroy;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        Destroy(other.gameObject);
        if (other.name.Contains("S1"))
        {
            GameObject.Find("Point1").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S2"))
        {
            GameObject.Find("Point2").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S3"))
        {
            GameObject.Find("Point3").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S4"))
        {
            GameObject.Find("Point4").GetComponent<Ball>().TimetoGenerateNewball();

        }
    }
}

