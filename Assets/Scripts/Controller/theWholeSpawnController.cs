using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theWholeSpawnController : MonoBehaviour {
	private AsteriodSpawn myAsteriodSpawn;
	private EnemyShipSpawn myEnemyShipSpawn;
	private GameOver myGameOver;
	public float Interval = 3f;		//time between two spawns
	void Start()
	{
		myGameOver = GetComponent<GameOver> ();
		myAsteriodSpawn = GetComponent<AsteriodSpawn> ();
		myEnemyShipSpawn = GetComponent<EnemyShipSpawn> ();
		StartCoroutine (SpawnEnemy ());
	}
	IEnumerator SpawnEnemy()
	{
		while (!(myGameOver.IsGameOver)) {
			yield return StartCoroutine (myEnemyShipSpawn.SpawnRollingShip ());
			yield return new WaitForSeconds (Interval);
			yield return StartCoroutine (myAsteriodSpawn.SpawnRandom ());
			yield return new WaitForSeconds (Interval);
			yield return StartCoroutine (myAsteriodSpawn.SpawnAsteriodLine ());
			yield return new WaitForSeconds (Interval);
		}
	}
}