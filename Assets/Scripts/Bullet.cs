using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1;
    public float delay = 4;
    Vector2 startPosition;

    void Awake()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Destroy(gameObject, delay);
    }
}
