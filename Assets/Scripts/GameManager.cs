using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PlayerShip ship;
    AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
    }

 
    void Update()
    {
        
    }
}
