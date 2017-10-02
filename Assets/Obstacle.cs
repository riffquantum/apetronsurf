using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	//movement speed (0=no movement)
	public float speed = 0;

	//weird rigid body variable thing
	public Rigidbody2D rb;

	//switch movement direction every x seconds
	public float switchTime = 2;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();

		//initial movement direction
		rb.velocity = Vector2.up * speed;

		InvokeRepeating ("Switch", 0, switchTime);
	}
	

	void Switch () {
		rb.velocity *= -1;
	}
}
