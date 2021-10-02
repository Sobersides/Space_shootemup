using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject smallAmmo;
    Rigidbody rb;
    Vector3 mouse;

    void Turret()
    {
        var newSmallAmmo = Instantiate(smallAmmo, this.transform);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Turret();
            print(mouse);
        }

        float leftAngle = Vector2.Angle(rb.velocity, Vector2.left);
        float rightAngle = Vector2.Angle(rb.velocity, Vector2.right);

        mouse = Input.mousePosition;
        if (leftAngle < 0)
        {
            print("left");
        }

    }
}
