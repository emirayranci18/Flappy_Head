using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ziplama : MonoBehaviour
{

    
    private Rigidbody2D rb;
    public static bool pausecheck = false;
    AudioSource audio;
    private float jumpSpeed=4.5f;
    public AudioClip bass;
    public GameObject gameover;
    public GameObject stop;
    public GameObject jump;


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        gameover.SetActive(false);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jump()
    {
        
            rb.velocity = Vector2.up * jumpSpeed;

        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "asama")
        {
            Time.timeScale = 0;
            pausecheck = true;
            audio.clip = bass;
            audio.Play();
            gameover.SetActive(true);
            stop.SetActive(false);
            jump.SetActive(false);
        }

    }






}
