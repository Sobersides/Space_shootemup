using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGun : MonoBehaviour
{
    public GameObject basicBeam;
    public float fireRate = 2;
    float tmp = 0;
    public void mainGun()
    {
        var newBeam = Instantiate(basicBeam, transform);
        
    }

    void Update()
    {

        if (Input.GetButton("Fire1") && tmp <= 0)
        {
            tmp = fireRate;
            mainGun();
        }
        tmp -= Time.deltaTime;

    }
}
