using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ring2chane : MonoBehaviour {

    public GameObject Eventcontroller;
    private Image change;
    public Sprite brownBg;
    public Sprite GreenBg;

    public GameObject sub21;
    public GameObject sub22;
    public GameObject Ringtwoobj;
    // Use this for initialization
    void Start () {
        change = this.GetComponent<Image>();
        change.sprite = brownBg;
        sub21.SetActive(true);
        sub22.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Eventcontroller.GetComponent<Btn>().RingTwo)
        {
            change.sprite = GreenBg;
            sub21.SetActive(false);
            sub22.SetActive(true);
            Ringtwoobj.GetComponent<RotationTracker>().enabled=true;
  
            
        }

        if (!Eventcontroller.GetComponent<Btn>().RingTwo)
        {
            change.sprite = brownBg;
            sub21.SetActive(true);
            sub22.SetActive(false);
            Ringtwoobj.GetComponent<RotationTracker>().enabled = false;
        }

    }
}