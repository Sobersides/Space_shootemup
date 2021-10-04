using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousDown : MonoBehaviour
{
	public float speed = 5f;
	public float timeUntilDelete;
	void Awake()
	{
		var rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.down * speed;

		Destroy(this.gameObject, timeUntilDelete);
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
