using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Flame { Low, Medium, High };

public class PlayerShip : MonoBehaviour
{

    public float Thrust;
    public float DefaultThrust;
    public float MaxVelocity;
    public float MaxAngularVelocity;
    public float MaxRotationAngle;
    public GameObject highFlame;
    public GameObject mediumFlame;
    public GameObject lowFlame;
    public Flame flame;

    private Rigidbody2D rb;
    private float initialGravityScale;

    private bool allowCutoff = true;
    private bool allowThrust = true;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponentInChildren<Rigidbody2D>();
        initialGravityScale = rb.gravityScale;
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Flame lastFlame = flame;
        flame = Flame.Low;

        if (allowCutoff && verticalInput >= 0.0f)
        {
            rb.AddForce(transform.up * DefaultThrust);
            flame = Flame.Medium;
        }

        if (allowThrust && verticalInput > 0.0f && rb.velocity.magnitude < MaxVelocity)
        {
            rb.AddForce(transform.up * Thrust);
            flame = Flame.High;
        } //else if (flame != Flame.High && flame != Flame.Medium) {

        //}

        if (flame != lastFlame)
        {

            lowFlame.SetActive(false);
            mediumFlame.SetActive(false);
            highFlame.SetActive(false);

            if (flame == Flame.Low)
            {
                lowFlame.SetActive(true);
            }
            else if (flame == Flame.Medium)
            {
                mediumFlame.SetActive(true);
            }
            else
            {
                highFlame.SetActive(true);
            }
        }




        if (horizontalInput > 0.0f)
        {
            // Right
            rb.AddTorque(-1f, ForceMode2D.Impulse);
        }
        else if (horizontalInput < 0.0f)
        {
            // Left
            rb.AddTorque(1f, ForceMode2D.Impulse);
        }

        ClampRotationAngle();
    }

    void ClampRotationAngle()
    {
        rb.rotation = Mathf.Clamp(rb.rotation, -MaxRotationAngle, MaxRotationAngle);
        rb.angularVelocity = Mathf.Clamp(rb.angularVelocity, -MaxAngularVelocity, MaxAngularVelocity);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ship collision " + collision.gameObject.name);
        gm.HealthStatus(-1f);
        
    }


    public void StopFalling()
    {
        rb.gravityScale = 0;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;
        allowCutoff = false;
    }

    public void ResumeFalling()
    {
        rb.gravityScale = initialGravityScale;
        allowCutoff = true;
    }

    public void StopRising()
    {
        rb.velocity = Vector2.zero;
        allowThrust = false;
    }

    public void ResumeRising()
    {
        allowThrust = true;
    }

    
}
