using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pizzamove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -3;

    float number;
    public static bool pizza;
    public static int sayi2 = 0;



    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (ziplama.pausecheck)
        {
            transform.Translate(0, 0, 0);
        }
        else
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);




        }
        

    }
    

   

    
}
