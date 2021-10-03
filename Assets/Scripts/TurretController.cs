using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject smallAmmo;
    Vector3 mouse;
    Vector3 turretPosition;
    float angle;
    public float cooldown = 0.4f;
    float tmp = 0;
    void Turret()
    {
        var newSmallAmmo = Instantiate(smallAmmo, transform.position, transform.rotation);

    }

    void Update()
    {
 
        if (Input.GetKey(KeyCode.Mouse1) && tmp < 0)
        {
            tmp = cooldown;
            Turret();
        }
        tmp -= Time.deltaTime;
        mouse = Input.mousePosition;
        turretPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        mouse.x -= turretPosition.x;
        mouse.y -= turretPosition.y;
        angle = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

    }
}
