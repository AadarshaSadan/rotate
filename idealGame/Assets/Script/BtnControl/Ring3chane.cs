using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ring3chane : MonoBehaviour {

    public GameObject Eventcontroller;
    private Image change;
    public Sprite brownBg;
    public Sprite GreenBg;

    public GameObject sub21;
    public GameObject sub22;
    public GameObject Ringthreeobj;
    // Use this for initialization
    void Start ()
    {
        change = this.GetComponent<Image>();
        change.sprite = brownBg;
        sub21.SetActive(true);
        sub22.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Eventcontroller.GetComponent<Btn>().RingThree)
        {
            change.sprite = GreenBg;
            sub21.SetActive(false);
            sub22.SetActive(true);
            Ringthreeobj.GetComponent<RotationTracker>().enabled=true;
        }

        if (!Eventcontroller.GetComponent<Btn>().RingThree)
        {
            change.sprite = brownBg;
            sub21.SetActive(true);
            sub22.SetActive(false);
            Ringthreeobj.GetComponent<RotationTracker>().enabled = false;
        }

    }
}