using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScreenShotCapturer : MonoBehaviour 
{
	//refrences to the gameobjects which you dont want to show in the sceenshot
	public GameObject[] objectsToHide;
	//refrence to the ui image onto which you want to show the captured screenShot
	public Image temp_DisplayImage;
	//for storing the screenShot name
	private string screenshot_name;
	//for storing the captured screenshot so we can pass it to the temp_DisplayImage
	private Sprite capturedSprite;
	//refrence to the folder path onto which we want to save our sceenShots
	private string pathToSave;


	//this function is called from the button from which you want to capture the image
	public void CaptureScreenShot()
	{
		//start the coroutine  so that we can capture the frame
		StartCoroutine(CaptureScreen());

		//note:
		//you can play the camera or capture sound from here
	}

	//Actual capturing saveing and displaying takes place from here.....................
	IEnumerator CaptureScreen()
	{
		//hide the gameObject which you want to hide on screenShot
		EnableDisableObjects(false);
		//wait for the end of the frame
		yield return new WaitForEndOfFrame();
		//refrence to the path folder for saving the screenShots
		//you can put any name in place of "/ScreenShots/" the name below is not compulsory, i mean the name ScreenShot
		//you can put any name you want
		pathToSave=Application.persistentDataPath+"/ScreenShots/";
		//check if the folder exists or not
		//if folder to save screenshot doesnot exists then create new folder else proceed screen capturing
		if(!System.IO.Directory.Exists(pathToSave))
		{
			System.IO.Directory.CreateDirectory(pathToSave);
		}
		else
		{
			//create the unique image name
			screenshot_name= file_name(System.Convert.ToInt32(Screen.width), System.Convert.ToInt32(Screen.height));
			//capture screenshot and save to the folder with the unique name
			//you can also use Application.CaptureScreenshot() instead of ScreenCapture.CaptureScreenshot() the work is same
			ScreenCapture.CaptureScreenshot(pathToSave+screenshot_name);
			//after capturing it takes time to save the image to disk so wait till the end of next frame
			yield return new WaitForEndOfFrame();
			//create a texture2D so that we can create a sprite to display the captured screenshot to the screen
			Texture2D screenShot=new Texture2D(Screen.width,Screen.height);
			//accessing only the bytes of recently captured sceenshot so that we can map the obtained byte values to the
			//created texture2D
			byte[] data=File.ReadAllBytes(pathToSave+screenshot_name);
			//applying the data of accessed screenshot data to the texture 2d
			screenShot.LoadImage(data);
			//creating the sprite using the texture 2d
			capturedSprite=Sprite.Create(screenShot,new Rect(0.0f,0.0f,Screen.width,Screen.height),
			new Vector2(0.5f,0.5f),100f);
			//refrence the newly created screenshot sprite to the image sprite on which we want to display the screenshot
			temp_DisplayImage.sprite=capturedSprite;
		}
			//show gameObjects which were disabled during capturing the screenshots
			EnableDisableObjects(true);
	}

	//method that returns the unique name for the screenShot on the following format
	 string file_name(int width, int height)
     {
        return string.Format("ScreenShot_{0}x{1}_{2}.png",width,height,System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
     }

	//disable and enables the gameobjects according to the passed boolean value
	void EnableDisableObjects(bool value)
	{
		for(int i=0;i<objectsToHide.Length;i++)
		{
			objectsToHide[i].SetActive(value);
		}
	}

	//i  think this script may help you guys. feel free to change  and modify the script as your choice
	//cheers mate
	//Script by Jeevan Thapa
	//jeevanthapa135@gmail.com
}
