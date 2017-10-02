using UnityEngine;
using System.Collections;

public class SpaceBarTurn : MonoBehaviour {

	public Animator makeTurn;

	// Use this for initialization
	void Start () {
	
		makeTurn = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space) && makeTurn.GetCurrentAnimatorStateInfo (0).IsName ("kruisin")) {

			makeTurn.SetTrigger ("turnTrigger");


		}

		if (Input.GetKeyUp (KeyCode.Space) && makeTurn.GetCurrentAnimatorStateInfo (0).IsName ("grab")) {

			makeTurn.SetTrigger ("endTurnTrigger");

		} 
	}
}
