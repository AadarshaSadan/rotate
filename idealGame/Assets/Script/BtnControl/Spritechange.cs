using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spritechange : MonoBehaviour {

    public GameObject Eventcontroller;
    private Image change;
    public Sprite brownBg;
    public Sprite GreenBg;

    public GameObject subpanel1;
    public GameObject subpane2;
    // Use this for initialization
    void Start () {
        change = this.GetComponent<Image>();
        change.sprite = brownBg;
        subpanel1.SetActive(true);
        subpane2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Eventcontroller.GetComponent<Btn>().Pause)
        {
            change.sprite = GreenBg;
            subpanel1.SetActive(false);
            subpane2.SetActive(true);
            Time.timeScale = 0;
            
        }

        if (!Eventcontroller.GetComponent<Btn>().Pause)
        {
            change.sprite = brownBg;
            subpanel1.SetActive(true);
            subpane2.SetActive(false);
            Time.timeScale = 1;
        }

    }
}