using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spacebas : MonoBehaviour
{
    public GameObject jump;
    bool check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Playfirst.space == false)
        {
            Time.timeScale = 0;

            
        }
    }
    public void Ziplama()
    {
        if (Playfirst.space == false)
        {




            jump.SetActive(false);
            Time.timeScale = 1;
            Playfirst.space = true;
            check = true;
                }
    }
}
