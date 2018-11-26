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
            Physics.gravity = new Vector3(0f, -8.9f, 0f);
          
        }
        if (scene_name.name == "Level1")
        {
            Physics.gravity = new Vector3(0f, -20.2f, 0f);

        }

    }

    // Update is called once per frame
    void Update () {
       // Physics.gravity = Vector3(0, -21.0, 0);
    }
}
