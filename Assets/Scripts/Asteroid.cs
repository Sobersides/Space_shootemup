using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Maybe a kill trigger instead
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
