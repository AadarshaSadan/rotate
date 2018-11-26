using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Distroyobj : MonoBehaviour
{
    public bool isDestroy;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject point9;
    public GameObject point10;
    public GameObject point11;
    public GameObject point12;

    public string pointvaluestring;

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
     


        //Debug.Log("Random number:-  " + s);

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
        else if (other.name.Contains("S5"))
        {
            GameObject.Find("Point5").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S6"))
        {
            GameObject.Find("Point6").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S7"))
        {
            GameObject.Find("Point7").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S8"))
        {
            GameObject.Find("Point8").GetComponent<Ball>().TimetoGenerateNewball();

        }
        else if (other.name.Contains("S9"))
        {
            GameObject.Find("Point9").GetComponent<Ball>().TimetoGenerateNewball();

        }
        Destroy(other.gameObject);

    }
}

