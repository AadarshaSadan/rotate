using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ringtouch : MonoBehaviour
{
    public bool Onclik2;
    public bool Onclik3;
    public bool Onclik1;
    public GameObject Ring2obj;
    public GameObject Ring1obj;
    public GameObject Ring3obj;
    private int count = 1;
    private int count1 = 1;
    private int count2 = 1;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Screen Width : " + Screen.width);
    }

    private void OnEnable()
    {
        Debug.Log("RingTough is enable");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {


            if (Input.GetMouseButtonDown(0) && hit.collider.transform.parent.gameObject.name == "GameObject2")
            {
                Onclik2 = true;
                count++;
                //Debug.Log(count);
            }
            if (Input.GetMouseButtonDown(0) && hit.collider.transform.parent.gameObject.name == "Platform")
            {
                Onclik1 = true;
                count1++;

            }
            if (Input.GetMouseButtonDown(0) && hit.collider.transform.parent.gameObject.name == "GameObject")
            {
                Onclik3 = true;
                count2++;

            }

            //  Debug.Log(hit.collider.transform.parent.gameObject.name);
        }
        offRotationall();


    }


    void offRotationall()
    {
        if (Onclik2)
            Ring2obj.GetComponent<RotationTracker>().enabled = false;

        if (count % 2 != 0)
        {
            Onclik2 = false;
            Ring2obj.GetComponent<RotationTracker>().enabled = true;
        }

        if (Onclik1)
            Ring1obj.GetComponent<RotationTracker>().enabled = false;

        if (count1 % 2 != 0)
        {
            Onclik1 = false;
            Ring1obj.GetComponent<RotationTracker>().enabled = true;
        }

        if (Onclik3)
            Ring3obj.GetComponent<RotationTracker>().enabled = false;

        if(count2 % 2!=0)
        {
            Onclik3 = false;
            Ring3obj.GetComponent<RotationTracker>().enabled = true;

        }
            


    }




}
