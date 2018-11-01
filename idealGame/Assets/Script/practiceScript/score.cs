using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class score : MonoBehaviour {

    // Use this for initialization
    public int _total;
    public float value_;
    public float coin;
    public Text downtext;

    public Text buttoncoinupdate;

	void Start () {
        _total = 20;
    }
	
	// Update is called once per frame
	void Update () {
        buttoncoinupdate.text = _total.ToString();
        value_ = CrossPlatformInputManager.GetAxis("Horizontali");
    }

   public void decrease()
    {
        coin = _total / 5;
        coin = coin - 1;
        downtext.text = coin.ToString();
        _total = _total - 5;

    }
}
