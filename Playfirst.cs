using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Playfirst : MonoBehaviour
{

	public Button yourButton;
	public static bool space=true;
	

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	
	}

	void TaskOnClick()
	{
		
		SceneManager.LoadScene("SampleScene");
		ziplama.pausecheck = false;
		space = false;
	}
}
