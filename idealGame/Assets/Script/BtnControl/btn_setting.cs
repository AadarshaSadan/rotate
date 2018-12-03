using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_setting : MonoBehaviour {

    public GameObject gametitle;
    public GameObject button1;
    public GameObject tabtoplay;
    public GameObject settingPanall;
   

    [SerializeField]
    private int count_btnSetting;

	// Use this for initialization
	void Start () {
        count_btnSetting = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HideGameObject()
    {
        settingPanall.SetActive(true);
        gametitle.SetActive(false);
        button1.SetActive(false);
        tabtoplay.SetActive(false);
    }
   public void ShowGameObject()
    {
        settingPanall.SetActive(false);
        gametitle.SetActive(true);
        button1.SetActive(true);
        tabtoplay.SetActive(true);
    }

    public void FromSettingicon()
    {
        count_btnSetting++;
        if (count_btnSetting % 2 != 0)
        {
            HideGameObject();

        }
        else
        {
            ShowGameObject();
        }
    }

    public void Music()
    {
        Debug.Log("music");
    }

    public void Sound()
    {
        Debug.Log("sound");
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }
        
}
