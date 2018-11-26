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
        total = 0;


        int[] RandomNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        float Randomss = Random.Range(1, RandomNumber.Length);
        float Random1 = Random.Range(1, RandomNumber.Length);
        float Random2 = Random.Range(1, RandomNumber.Length);
        //float Random3 = Random.Range(1, RandomNumber.Length);
        //float Random4= Random.Range(1, RandomNumber.Length);
        //float Random5 = Random.Range(1, RandomNumber.Length);

        stringpoint = Randomss.ToString();
        stringpoint1 = Random1.ToString();
        stringpoint2 = Random2.ToString();
        //stringpoint3 = Random2.ToString();

        //stringpoint4 = Random2.ToString();
        //stringpoint5 = Random2.ToString();
        //stringpoint6 = Random2.ToString();
        //stringpoint7 = Random2.ToString();
        Debug.Log(stringpoint);
        Debug.Log(stringpoint1);

        point1.SetActive(true);
        point2.SetActive(true);
        point3.SetActive(true);





    }

    //Update is called once per frame
    void Update()
    {
        TotalAll.text = total.ToString();
        mystring = GameObject.Find("Downcollider").GetComponent<Distroyobj>().pointvaluestring;
        Debug.Log("my string " + mystring);

        /* if (total >= 0)
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

     */

        Getcoin = total / 5;
        // Debug.Log(Getcoin);





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
        Debug.Log("This is total value:-" + total);

        if (total >= 1)
            firstball.SetActive(true);
        if (total >= 2)
            secondball.SetActive(true);
        if (total >= 3)
            thirdball.SetActive(true);
        if (total >= 4)
            fourthball.SetActive(true);
        if (total >= 5)
            fifthball.SetActive(true);
        if (total >= 6)
            sixthball.SetActive(true);
        if (total >= 7)
            sevenball.SetActive(true);
        if (total >= 8 && Scene_Name.name == "Game")
        {
            eightball.SetActive(true);
            SceneManager.LoadScene("Level1");
        }
        if (total >= 8 && Scene_Name.name == "Level1")
        {
            eightball.SetActive(true);
            SceneManager.LoadScene("Level2");
        }






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

    private void Reset_Total(Scene S)
    {
        Debug.Log(S.name);
    }


}
