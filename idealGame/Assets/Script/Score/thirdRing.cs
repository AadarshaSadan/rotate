using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thirdRing : MonoBehaviour {

    public bool OnRing2;
    public int ___count = 5;
    

    private void OnTriggerEnter(Collider other)
    {
        OnRing2 = true;
        ___count = ___count + 1;
        FindObjectOfType<Total>().Total_value(1);
        AudioSource sound = GameObject.Find("Ground").GetComponent<AudioSource>();
        sound.Play();

        if(other.gameObject.name== "Enemy")
        {
            FindObjectOfType<Total>().GameOverGame();
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        OnRing2 = false;
    }
}