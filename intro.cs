using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("first", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void first()
    {
        SceneManager.LoadScene("mainmenu");
        Screen.SetResolution(Screen.currentResolution.width / 2, Screen.currentResolution.height / 2, true);
    }
}
