using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	public int score = 0;
	public int highScore = 0;
	public Text scoreText;
	public Text highScoreText;
	public static gameManager instance = null;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		Setup ();
	}

public void Setup(){

	}

	public void Reset (){
		Application.LoadLevel (Application.loadedLevel);
	}

public void addScore(){
		score++;
		scoreText.text = "Score: " + score;
	}
}
