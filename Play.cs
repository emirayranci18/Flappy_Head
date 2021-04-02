using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Play : MonoBehaviour
{

	public Button yourButton;
	AudioSource audio;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		audio = GetComponent<AudioSource>();

	}

	void TaskOnClick()
	{
		
		ziplama.pausecheck = false;
		SceneManager.LoadScene("SampleScene");
		Playfirst.space = false;


	}

}
