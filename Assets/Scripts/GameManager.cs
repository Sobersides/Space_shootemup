using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerShip ship;
    AudioSource music;

    public float takeDamageCooldown;
    public float health;
    float healthTmp;

    int score;

    public Text resultText;
    public Text healthBar;
    public Text scoreText;

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
        HealthStatus(0f);
        resultText.text = "";
        scoreText.text = "";
    }

 
    void Update()
    {
        healthTmp -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
    public void HealthStatus(float damage)
    {
        if (healthTmp <= 0)
        {
            health += damage;
            healthTmp = takeDamageCooldown;
            healthBar.text = "Health: " + health;
        }
        if (health <= 0)
        {
            Time.timeScale = 0;
            scoreText.text = "Score: " + score;
            resultText.text = "Game over\n Press R to restart";
        }
        
    }
    public void ScoreStatus()
    {

    }
}
