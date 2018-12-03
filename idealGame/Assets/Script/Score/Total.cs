using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    //Game object to update each ball and count to level upgrade
    public GameObject firstball;
    public GameObject secondball;
    public GameObject thirdball;
    public GameObject fourthball;
    public GameObject fifthball;
    public GameObject sixthball;
    public GameObject sevenball;
    public GameObject eightball;
    public GameObject nineball;
    public GameObject tenball;
    public GameObject elevenball;
    public GameObject twelveball;
    public GameObject thirteenball;
    public GameObject fourteenball;
    public GameObject fifteenball;
    public GameObject sixteenball;



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

    private string mystring;
    private string stringpoint;
    private string stringpoint1;
    private string stringpoint2;
    private string stringpoint3;
    private string stringpoint4;
    private string stringpoint5;
    private string stringpoint6;
    private string stringpoint7;
    private string stringpoint8;

    Scene Scene_Name;


    void Start()
    {

        Scene_Name = SceneManager.GetActiveScene();
        Debug.Log(Scene_Name.name);
        total = 0;
    }

    //Update is called once per frame
    void Update()
    {
        TotalAll.text = total.ToString();
        mystring = GameObject.Find("Downcollider").GetComponent<Distroyobj>().pointvaluestring;

        if(total>=8)
        {
            if (Scene_Name.name== "Game")
            {
                SceneManager.LoadScene("Level1");
            }
            if (Scene_Name.name == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }

            if (Scene_Name.name == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }

            if (Scene_Name.name == "Level3")
            {
                SceneManager.LoadScene("Level4");
            }

            if (Scene_Name.name == "Level4")
            {
                SceneManager.LoadScene("Level5");
            }

            if (Scene_Name.name == "Level5")
            {
                SceneManager.LoadScene("Level6");
            }
            if (Scene_Name.name == "Level6")
            {
                SceneManager.LoadScene("Level7");
            }

            if (Scene_Name.name == "Level7")
            {
                SceneManager.LoadScene("Level8");

            }


            if (Scene_Name.name == "Level8")
            {
                SceneManager.LoadScene("Level9");
            }


            if (Scene_Name.name == "Level9")
            {
                SceneManager.LoadScene("Level10");
            }


            if (Scene_Name.name == "Level10")
            {
                SceneManager.LoadScene("Level11");
            }


            if (Scene_Name.name == "Level11")
            {
                SceneManager.LoadScene("Level12");
            }

            if (Scene_Name.name == "Level12")
            {
                SceneManager.LoadScene("Level13");
            }

            if (Scene_Name.name == "Level13")
            {
                SceneManager.LoadScene("Level4");
            }

        }

        //reducing the numbber of ball
        if (Scene_Name.name == "Game")
        {
            ReduceEightBallTotal(total);
        }
        if (Scene_Name.name == "Level1")
        {
            ReduceEightBallTotal(total);
        }

        if (Scene_Name.name == "Level2")
        {
            ReduceEightBallTotal(total);
        }

        if (Scene_Name.name == "Level3")
        {
            ReduceEightBallTotal(total);

        }

        if (Scene_Name.name == "Level4")
        {
            ReduceEightBallTotal(total);
        }

        if (Scene_Name.name == "Level5")
        {
            
        }
        if (Scene_Name.name == "Level6")
        {
            
        }

        if (Scene_Name.name == "Level7")
        {
            

        }


        if (Scene_Name.name == "Level8")
        {
            SceneManager.LoadScene("Level9");
        }


        if (Scene_Name.name == "Level9")
        {
            SceneManager.LoadScene("Level10");
        }


        if (Scene_Name.name == "Level10")
        {
            SceneManager.LoadScene("Level11");
        }


        if (Scene_Name.name == "Level11")
        {
            SceneManager.LoadScene("Level12");
        }

        if (Scene_Name.name == "Level12")
        {
            SceneManager.LoadScene("Level13");
        }

        if (Scene_Name.name == "Level13")
        {
            SceneManager.LoadScene("Level4");
        }





    }

    public void getvalue()
    {
        //Getcoin = Getcoin - 1;
        if (Getcoin == 1)
            btnOn = true;

        //total = total - 5;
        coincount.text = Getcoin.ToString();
        TotalAll.text = total.ToString();
    }

    public void Total_value(int a)
    {
        total += a;
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

        if (negativeball == 1)
        {
            thirdife.SetActive(false);
        }
        if (negativeball == 2)
        {
            secondlife.SetActive(false);
        }
        if (negativeball >= 3)
        {
            fstlife.SetActive(false);
            GameObject.Find("Eventcontroller").GetComponent<Btn>().Pause = true;
            gameoverpanel.SetActive(true);
            pauseswitch.SetActive(false);
            Time.timeScale = 0;
        }




    }

    public void ReduceEightBallTotal(int valueoftotal)
    {

        if (total >= 8)
            firstball.SetActive(false);
        if (total >= 7)
            secondball.SetActive(false);
        if (total >= 6)
            thirdball.SetActive(false);
        if (total >= 5)
            fourthball.SetActive(false);
        if (total >= 4)
            fifthball.SetActive(false);
        if (total >= 3)
            sixthball.SetActive(false);
        if (total >= 2)
            sevenball.SetActive(false);
        if (total >= 1)
            eightball.SetActive(false);

    }








}
