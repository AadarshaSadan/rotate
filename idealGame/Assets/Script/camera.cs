﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public float pixelsToUnits = 100;
    private Camera cam;
    float camleft;
    float camup;
    float camright;
    float camdown;
    float screenwidth;
    float screnheight;
    float screendepth = -10f;
    Vector3 currentcam;
    public Transform testpoint;

    public float leftdistance;

    public float rightdistance;
    //
    public Transform[] gameAssets;

    private void Start()
    {
        //DefaultScreenSize  height 370,
        //defaultScreenWidth  231
        //  Debug.Log("screenheight="+screnheight +  "width=" + screenwidth);
        Debug.Log(Screen.height+"screenwidth:"+Screen.width);

    
        
       // gameAssets[0].transform.position = new Vector2(Screen.width/2f, Screen.height/2f);
        //gameAssets[1].transform.localScale = new Vector2(screenwidth/76f, screnheight/28f);
        //gameAssets[1].transform.position = new Vector2(0f, camdown+11.1f);
        //gameAssets[2].transform.position = new Vector2(0f, 12/camdown);
        //  gameAssets[3].transform.position = new Vector2(screenwidth / -6.89f, screnheight / -11.11f);
        //gameAssets[4].transform.position = new Vector2(screenwidth /5.6f, screnheight / -7.2f);
        // gameAssets[5].transform.position = new Vector2(screenwidth / -4.26f, screnheight / -8.1f);

        //rightdistance = screenwidth / 6f;
        //leftdistance = screenwidth / -6f;



    }

    void Awake()
    {
        //cam = Camera.main;
    }

    void Update()
    {
        // cam.orthographicSize = Screen.height / pixelsToUnits / 2;
    }
}