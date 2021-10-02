using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBeam : MonoBehaviour
{
    public float beamWidht = 0.2f;
    public float beamHeight = 1f;
    bool hitSomething = false;
    public float destroyDelay = 1f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        hitSomething = true;
        print("HIT");
    }
    void FixedUpdate()
    {
        if (hitSomething == false && beamHeight <= 10f)
        {
            transform.localScale = new Vector2(beamWidht, beamHeight += 0.5f);
            transform.localPosition = new Vector2(0, beamHeight / 2f);
        }

        Destroy(gameObject, destroyDelay);
    }
}
