using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tabplay : MonoBehaviour {
    public int c = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 

        if(Input.GetMouseButtonDown(0))
        {
           SceneManager.LoadScene("Game");
        }
		
	}

    void camerashot()
    {

    }
}
