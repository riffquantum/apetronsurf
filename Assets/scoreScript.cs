using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

	public int score = 0;
	public Text scoreText;
	

	// Update is called once per frame
	void Update () {
		score++;
		scoreText.text = "Score: " + score;

	}
}
