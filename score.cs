using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreui;
    public Text scoreafter;
    public float speed = -3;
    public  int sayi = 0;
    public int sayi2 = 0;
    public int high = 0;
    AudioSource audio;
    public AudioClip win;


    public GameObject pizza;
    float number;
    public bool cloo = false;
    public bool cloo2 = false;
    GameObject clone;
    GameObject clone2;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = win;
    }

    // Update is called once per frame
    void Update()
    {
      
        scoreui.text = "" + (sayi+sayi2);
        scoreafter.text = "" + (sayi + sayi2);


     /*   if (cloo2)
        {
            number = Random.Range(-3.15f, 3.25f);
            GameObject clone = Instantiate(pizza, new Vector3(4.5f, number, 0), Quaternion.identity);
            cloo2 = false;

            if (cloo && sayi > 1)
            {

               
                Destroy(clone);
                cloo = false;

            }
        }*/

    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.transform.tag == "score")
        {
            sayi++;
            
            
            if (sayi%2==0)
            {
                number = Random.Range(-3.15f, 3.25f);
                clone = Instantiate(pizza, new Vector3(4.5f, number, 0), Quaternion.identity);
                cloo = true;
            }
            if (sayi % 2 == 1)
            {
                number = Random.Range(-3.15f, 3.25f);
                clone2 = Instantiate(pizza, new Vector3(4.5f, number, 0), Quaternion.identity);
                cloo2 = true;
            }


        }


        


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "pizza")
        {
            sayi2++;
            if (sayi%2==0)
            {
                Destroy(clone2);
                cloo = false;
                audio.Play();
                
            }
            if (sayi % 2 == 1)
            {
                Destroy(clone);
                cloo2 = false;
                audio.Play();
            }







        }

    }
}
