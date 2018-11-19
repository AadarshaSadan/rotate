using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstring : MonoBehaviour {
    public bool OnRing1;
    public int _count = 1;
// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        OnRing1 = true;
        //_count++;
        FindObjectOfType<Total>().Total_value(1);
        AudioSource sound = GameObject.Find("Ground").GetComponent<AudioSource>();
        sound.Play();
       
    }

    private void OnTriggerExit(Collider other)
    {
        OnRing1 = false;
    }
}
