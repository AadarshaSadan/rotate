using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ring1chane : MonoBehaviour {

    public GameObject Eventcontroller;
    private Image change;
    public Sprite brownBg;
    public Sprite GreenBg;

    public GameObject subanel1;
    public GameObject supane2;
    public GameObject Ringoneobj;
    // Use this for initialization
    void Start () {
        change = this.GetComponent<Image>();
        change.sprite = brownBg;
        subanel1.SetActive(true);
        supane2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Eventcontroller.GetComponent<Btn>().RingOne)
        {
            change.sprite = GreenBg;
            subanel1.SetActive(false);
            supane2.SetActive(true);
            Ringoneobj.GetComponent<RotationTracker>().enabled=true;
  
            
        }

        if (!Eventcontroller.GetComponent<Btn>().RingOne)
        {
            change.sprite = brownBg;
            subanel1.SetActive(true);
            supane2.SetActive(false);
            Ringoneobj.GetComponent<RotationTracker>().enabled = false;
        }

    }
}