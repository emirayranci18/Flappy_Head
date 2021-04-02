using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
	
	public Button yourButton;
	AudioSource audio;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		

	}

	void TaskOnClick()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("mainmenu");
	}
}
