using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyRollingShipPos
{
	public Vector2 XMinMax;
	public float YPos;
	public float SpawnIntervalSeconds = 1.5f;
}

public class EnemyShipSpawn : MonoBehaviour {
	public GameObject EnemyRollingShip;
	public EnemyRollingShipPos myEnemyRollingShipPos;
	//spawn enemy rolling ship for 20 times
	public IEnumerator SpawnRollingShip()
	{
		for (int k = 0; k < 20; k++) {
			Vector3 newPosition = new Vector3 (Random.Range (myEnemyRollingShipPos.XMinMax.x, myEnemyRollingShipPos.XMinMax.y), myEnemyRollingShipPos.YPos, 0f);
			GameObject enemyship = Instantiate (EnemyRollingShip, newPosition, EnemyRollingShip.transform.rotation);
			enemyship.SetActive (true);
			yield return new WaitForSeconds (myEnemyRollingShipPos.SpawnIntervalSeconds);
		}
	}
}