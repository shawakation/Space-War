using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public GameObject GameOverText;
	private bool isGameOver;
	void Start()
	{
		GameOverText.SetActive (false);
		isGameOver = false;
	}
	public void gameOverProcess()
	{
		GameOverText.SetActive (true);
		isGameOver = true;
	}
	public bool IsGameOver
	{
		get { return this.isGameOver; }
	}
}
