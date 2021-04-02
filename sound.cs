using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip hymn;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = hymn;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (ziplama.pausecheck)
        {
            audio.volume = 0;
        }
        else
        {
            audio.clip = hymn;
            audio.Play();
        }*/
    }
}
