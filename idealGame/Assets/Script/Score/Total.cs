using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Total : MonoBehaviour
{

    public Text TotalAll;
    public Text GameendText;
    public int total;
    public int negativeball;
    public int gameend;
    public bool EndGame;

    public GameObject gameoverpanel;
    public GameObject pauseswitch;


    private int count1 = 1;

    public GameObject point4;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject point9;

    public int Getcoin;
    public Slider velocityslide;
    public int range = 5;

    public Text coincount;

    private bool onData;

    public int count_;
    // Use this for initialization

    [SerializeField]
    private int btn_count;


    public int reduce;
    public int countfromTotal;

    public int Re;
    public bool btnOn;

    //Game life object true//false
    public GameObject fstlife;
    public GameObject secondlife;
    public GameObject thirdife;

    void Start()
    {
        total = 0;

    }

    // Update is called once per frame
    void Update()
    {



        TotalAll.text = total.ToString();


        if (total >= 0)
            point2.SetActive(true);
        if (total > 1)
            point1.SetActive(true);
        if (total > 5)
            point3.SetActive(true);
        if (total > 10)
            point4.SetActive(true);


        if (total > 15)
            point5.SetActive(true);
        if (total > 20)
            point6.SetActive(true);
        if (total > 25)
            point7.SetActive(true);
        if (total > 26)
            point8.SetActive(true);
        if (total > 30)
            point9.SetActive(true);


        Getcoin = total / 5;
        // Debug.Log(Getcoin);





    }

    public void getvalue()
    {


        Getcoin = Getcoin - 1;
        if (Getcoin == 1)
            btnOn = true;

        total = total - 5;
        coincount.text = Getcoin.ToString();
        TotalAll.text = total.ToString();


    }

    public void Total_value(int a)
    {

        total += a;
        //Debug.Log(total);

    }

    void Check_diff(int gameend)
    {
        if (gameend < 2)
        {
            EndGame = true;
            velocityslide.interactable = false;
            velocityslide.value = 0;
            onData = false;
        }
        else
        {
            velocityslide.interactable = true;
            onData = true;

        }
    }


    public void NegativevalueCount(int count)
    {
        negativeball += count;
        Debug.Log("negative_ball=" + negativeball);

        if(negativeball==1)
        {
            thirdife.SetActive(false);
        }
        if(negativeball==2)
        {
            secondlife.SetActive(false);
        }
        if(negativeball==3)
        {
            fstlife.SetActive(false);
            GameObject.Find("Eventcontroller").GetComponent<Btn>().Pause = true;
            gameoverpanel.SetActive(true);
            pauseswitch.SetActive(false);
        }
      
      
           

    }


}
