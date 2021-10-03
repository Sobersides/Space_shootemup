using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBeam : MonoBehaviour
{
    public float beamWidht = 0.2f;
    public float beamStartHeight = 1f;
    public float beamMaxHeight = 10f;
    bool hitSomething = false;

    public float destroyDelay = 1f;
    GameObject hull;
    void OnCollisionStay2D(Collision2D collision)
    {
        hitSomething = true;
            transform.localScale = new Vector2(beamWidht, beamStartHeight -= 0.5f);
        print("HIT");
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        hitSomething = false;
    }
    void FixedUpdate()
    {

        transform.rotation = transform.parent.rotation;
        transform.position = transform.parent.position;
        transform.localPosition = new Vector2(0, beamStartHeight / 2);
        if (hitSomething == false && beamStartHeight <= beamMaxHeight)
        {
            transform.localScale = new Vector2(beamWidht, beamStartHeight += 0.5f);
        }
        

        Destroy(gameObject, destroyDelay);
    }
}
