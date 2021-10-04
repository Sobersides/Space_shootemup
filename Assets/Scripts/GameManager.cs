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

    int score = 0;

    public Text resultText;
    public Text healthBar;
    public Text scoreText;
    public Text liveScoreText;

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
        HealthStatus(0f);
        ScoreStatus(0);
        resultText.text = "";
        scoreText.text = "";
    }

 
    void Update()
    {
        healthTmp -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
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
    public void ScoreStatus(int addScore)
    {
        score += addScore;
        liveScoreText.text = "Score: " + score;
    }
}
