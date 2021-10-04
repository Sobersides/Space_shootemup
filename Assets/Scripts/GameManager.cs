using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public PlayerShip ship;
    AudioSource music;

    public float takeDamageCooldown;
    public float health;
    float healthTmp;
    public Text healthBar;

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
        HealthStatus(0f);
        
    }

 
    void Update()
    {
        healthTmp -= Time.deltaTime;
    }
    public void HealthStatus(float damage)
    {
        if (healthTmp <= 0)
        {
            health += damage;
            healthTmp = takeDamageCooldown;
            healthBar.text = "Health: " + health;
        }
    }
}
