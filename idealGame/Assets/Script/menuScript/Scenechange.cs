﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour {




   public void nextscene()
    {
        SceneManager.LoadScene("Game");
    }


    public void exitgame()
    {
        Application.Quit();
    }

}