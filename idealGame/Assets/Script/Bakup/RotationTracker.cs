using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationTracker : MonoBehaviour {
    float x;
    public Slider speedslider;
    public Text veloc;
    public float speed;
    float TIme;
    float V;

    public bool onAnticlock;

    void Start()
    {
        speedslider.value = 10f;

    }

    void Update()
    {

        TIme = Time.deltaTime;
        if(onAnticlock)
            speed = -speedslider.value*1f;
        if(!onAnticlock)
            speed=speedslider.value * 1f;
        V = speed / TIme; 
        x += TIme * speed ;
        //Debug.Log(speed);
           

        
        transform.rotation = Quaternion.Euler(0f, x, 0f);
    }

  

}
