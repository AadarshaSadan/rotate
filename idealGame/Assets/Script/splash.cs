using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class splash : MonoBehaviour {
    private int getstringint;
    public Text Hint;
    public Text GTitle;
	// Use this for initialization
	void Start () {
       StartCoroutine(Waitingtime());
        message();
        gameTitle();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Waitingtime()
    {
        Debug.Log("start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }


    void message()
    {
        string[] names = new string[] { "Never trust Redball", "No ball in bomb", "speed high with level", "use accelerometer","you Rotate Ring" };
        getstringint = Random.Range(0,names.Length);
        Hint.text = names[getstringint].ToString();
        
    }

    void gameTitle()
    {
        string Gtitle = "IDEALGAME";
        GTitle.text = Gtitle.ToString();
    }
}
