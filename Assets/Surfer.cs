using UnityEngine;
using System.Collections;

public class Surfer : MonoBehaviour {
	//Speed
	public float speed;

	//Cut force
	public float force;

	//rigidbody var
	public Rigidbody2D rb;

	void OnCollisionEnter2D(Collision2D coll){
		//restart
		Application.LoadLevel (Application.loadedLevel);
	}

	// Use this for initialization
	void Start () {

		//go to the right
		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

		rb.velocity = Vector2.right * speed;

		//Cut
		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (Vector2.up * force);
	}
}
