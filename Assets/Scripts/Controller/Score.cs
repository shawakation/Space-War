using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text ScoreText;
	private int score;
	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	void UpdateScore()
	{
		ScoreText.text = "Score:" + score.ToString ();
	}
	void Start()
	{
		score = 0;
		UpdateScore ();
	}
}
