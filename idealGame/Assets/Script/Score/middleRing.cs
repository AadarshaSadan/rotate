using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class middleRing : MonoBehaviour {

    public bool middle;
    public int _Count;
    public GameObject gameoverpanel;
    public GameObject pauseswitch;
    
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
      
    }

    private void OnTriggerExit(Collider other)
    {
        middle = false;
        gameoverpanel.SetActive(true);
        AudioSource sound = GameObject.Find("parent_fire").GetComponent<AudioSource>();
        sound.Play();
        GameObject.Find("Eventcontroller").GetComponent<Btn>().Pause = true;
        pauseswitch.SetActive(false);
         
    }
}
