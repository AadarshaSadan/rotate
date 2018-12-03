using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class increaseGravity : MonoBehaviour {
    Scene scene_name;
	// Use this for initialization
	void Start () {
        scene_name = SceneManager.GetActiveScene();  
        if (scene_name.name == "Game")
        {
            Physics.gravity = new Vector3(0f, -2.00f, 0f);
          
        }
        if (scene_name.name == "Level1")
        {
            Physics.gravity = new Vector3(0f, -9.1f, 0f);

        }
        if(scene_name.name=="Level2")
        {
            Physics.gravity = new Vector3(0f, -15.81f, 0f);
        }
        if (scene_name.name == "Level3")
        {
            Physics.gravity = new Vector3(0f, -30.0f, 0f);
        }
        if (scene_name.name == "Level4")
        {
            Physics.gravity = new Vector3(0f, -50.0f, 0f);
        }


    }

    // Update is called once per frame
    void Update () {
       // Physics.gravity = Vector3(0, -21.0, 0);
    }
}
