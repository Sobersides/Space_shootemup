using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousDown : MonoBehaviour
{
	public float speed = 5f;
	void Awake()
	{
		var rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.down * speed;

		Destroy(this.gameObject, 5f);
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
