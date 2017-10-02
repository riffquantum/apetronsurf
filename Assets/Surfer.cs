using UnityEngine;
using System.Collections;


public class Surfer : MonoBehaviour {

	//Speed
	public float speed;
	public float topSpeed;

	//Turn
	public float force;
	public float turnSpeed;
	public float turnBackSpeed;

	//rigidbody var
	public Rigidbody2D rb;

	//rotate var
	private Transform rotate;




	void OnCollisionEnter2D(Collision2D coll){
		//restart

		Application.LoadLevel (Application.loadedLevel);
	}

	// Use this for initialization
	void Start () {

		//assignb RigidBody to variable
		rb = GetComponent<Rigidbody2D>();

		//assign transform to variable
		rotate = GetComponent<Transform>();

	}

	//

	void makeTurn () {

		//adds force against gravity to go up the wave
		rb.AddForce (Vector2.up * force);

		//decrease speed as you go up the wave
		//for (float i = speed; i > 30; i--){

		//speed = (speed - 0.5f); 
		//}

		//rotate surfer 
		float zAngle=transform.eulerAngles.z;
		if (zAngle > 35 && zAngle<=180)
		{
			zAngle = 35;
		}
		else if (zAngle < 340 && zAngle>180)
		{
			zAngle = 340;
		}            
		transform.eulerAngles = new Vector3(0, 0, zAngle);

		rotate.Rotate (Vector3.forward, turnSpeed, 0);

		}

	void turnBack (){

		//rotate.Rotate (Vector3.back, turnBackSpeed, 0);

	}

	// Update is called once per frame
	void Update () {

		rb.velocity = Vector2.right * speed;
		rotate.Rotate (Vector3.back, turnBackSpeed, 0);



		//Spacebar Turn
		if (Input.GetKey(KeyCode.Space)){

			//do function
			makeTurn ();
		}

		if (Input.GetKeyUp (KeyCode.Space)) {

			//do function
			//turnBack ();
			//inrease speed as you ride down the wave
			//for (float i = speed; i < topSpeed; i++){
				//speed++;
			//}
		}

		//Right Arrow Accelerate
        /* if (Input.GetKey (KeyCode.RightArrow)){

			for(int i = 30; i < topSpeed; i++) {
				rb.velocity = Vector2.right * speed++;
			}

		}	
		//Left Arrow Decelerate
		if (Input.GetKey (KeyCode.LeftArrow)){

			while (speed > 30) {	
				rb.velocity = Vector2.right * speed--;
			}
		} */

		//impulse, particle emitter 
        
        
	}
}
