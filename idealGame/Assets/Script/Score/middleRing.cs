using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class middleRing : MonoBehaviour {

   // public int
    public bool middle;
    public int _Count;
   
    void Start()
    {
        _Count = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        middle = true;
        _Count++;
        FindObjectOfType<Total>().NegativevalueCount(1);
       
        AudioSource sound = GameObject.Find("parent_fire").GetComponent<AudioSource>();
        sound.Play();


    }

    private void OnTriggerExit(Collider other)
    {
        middle = false;

    }
}
