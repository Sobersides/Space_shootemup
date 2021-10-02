using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalLimiter : MonoBehaviour
{

    public enum Direction
    {
        UP,
        DOWN
    }

    public Direction limitDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerShip player = other.GetComponent<PlayerShip>();
            if (limitDirection == Direction.UP)
            {
                player.StopRising();
            } 
            else if (limitDirection == Direction.DOWN)
            {
                player.StopFalling();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerShip player = other.GetComponent<PlayerShip>();
            if (limitDirection == Direction.UP)
            {
                player.ResumeRising();
            }
            else if (limitDirection == Direction.DOWN)
            {
                player.ResumeFalling();
            }
        }
    }
}
