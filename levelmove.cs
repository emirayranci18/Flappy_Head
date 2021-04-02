using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -3;
    public Text sayac;
    float number;
    public static bool pizza;
    


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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "back")
        {
            number = Random.Range(-1.95f,1.95f);
            transform.position = new Vector3(6.5f,number,0);
       
        }


    }
}
