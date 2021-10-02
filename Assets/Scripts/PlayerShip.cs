using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public float Thrust;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponentInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Thrust"))
        {
            rb.AddForce(transform.up * Thrust);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ship collision " + collision.gameObject.name);
    }

}
