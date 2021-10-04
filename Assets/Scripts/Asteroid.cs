using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public GameObject destroyAnimation;
    private ParticleSystem explosion;
    private CircleCollider2D collisionDetection;

    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponentInChildren<ParticleSystem>();
        collisionDetection = GetComponent<CircleCollider2D>();

        // Maybe a kill trigger instead
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Weapon")
        {
            if(collisionDetection)
            {
                collisionDetection.enabled = false;
            }
            destroyAnimation.SetActive(true);
            explosion.Play();
            Destroy(this.gameObject, .2f);
        }    
    }
}
