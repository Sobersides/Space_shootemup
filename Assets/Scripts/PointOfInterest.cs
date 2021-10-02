using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : MonoBehaviour
{
    Vector2 mouse;

    void Update()
    {
        mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = Vector2.Lerp(transform.position, mouse, 1f);
    }
}
