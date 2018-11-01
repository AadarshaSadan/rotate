using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{

    public int count1 = 1;
    public int count2 = 1;
    public int count3 = 1;
    public int count4 = 1;
    public bool Pause;
    public bool RingOne;
    public bool RingTwo;
    public bool RingThree;

    // Use this for initialization
    void Start()
    {
        RingOne = true;
        RingTwo = true;
        RingThree = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pausebuttonclick()
    {
        count1++;
        if (count1 % 2 != 0)
        {
            Pause = false;
        }
        else
        {
            Pause = true;
        }
    }

    public void Ring1()
    {
        count2++;
        if (count2 % 2 != 0)
        {
            RingOne = false;
        }
        else
        {
            RingOne = true;
        }
    }

    public void Ring2()
    {
        count3++;
        if (count3 % 2 != 0)
        {
            RingTwo = false;
        }
        else
        {
            RingTwo = true;
        }
    }
    public void Ring3()
    {
        count4++;
        if (count4 % 2 != 0)
        {
            RingThree = false;
        }
        else
        {
            RingThree = true;
        }
    }

    public void Gameovergotomain()
    {
        SceneManager.LoadScene("Game");
    }

}

