using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secondring : MonoBehaviour {

    public bool OnRing2;
    public int __count = 2;
  
  

    private void OnTriggerEnter(Collider other)
    {
        OnRing2 = true;
        if (other.gameObject.name == "Enemy")
        {
            FindObjectOfType<Btn>().Pause = true;
        }
        __count = __count + 2;
        FindObjectOfType<Total>().Total_value(1);
        AudioSource sound = GameObject.Find("Ground").GetComponent<AudioSource>();
        sound.Play();
       
    }

    private void OnTriggerExit(Collider other)
    {
        OnRing2 = false;
    }
}

