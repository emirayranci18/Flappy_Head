using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public Button esc;
    public Button go;
    public Text resume;
    public Text pausetext;
    public GameObject gameover;
    public GameObject resumee;
    public GameObject playagain;
    public GameObject stop;
    public GameObject spacebas;
    public bool check=false;
    public GameObject jump;


    void Start()
    {
        Button btn = esc.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        resumee.SetActive(false);
        Button btn2 = go.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && check==true)
        {
            spacebas.SetActive(false);
            Time.timeScale = 1;

            check = false;
        }

    }

    void TaskOnClick()
    {
        Time.timeScale = 0;
        ziplama.pausecheck = true;
        gameover.SetActive(true);
        resumee.SetActive(true);
        playagain.SetActive(false);
        pausetext.text = "Pause";
        playagain.SetActive(false);
        stop.SetActive(false);
        jump.SetActive(false);

    }

    void TaskOnClick2()
    {
        spacebas.SetActive(true);
        ziplama.pausecheck = false;
        gameover.SetActive(false);
        resumee.SetActive(false);
        playagain.SetActive(true);
        pausetext.text = "GameOver";
        stop.SetActive(true);
        check = true;
        jump.SetActive(true);





    }




}
