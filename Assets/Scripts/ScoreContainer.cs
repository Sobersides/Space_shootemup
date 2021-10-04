using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContainer : MonoBehaviour
{
    AudioSource music;
    public int highScore;
    bool playing = false;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        
        print("Well hello there");
    }

    // Update is called once per frame
    void Update()
    {

        if (playing == false)
        {
            print("play");
            music.Play();
            playing = true;
        }
    }
}
