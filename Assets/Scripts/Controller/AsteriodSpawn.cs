using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AsteriodPosition
{
	public Vector2 XMinMax;
	public float YPos;
	public float SpawnIntervalSeconds = 1f;
}
[System.Serializable]
public class AsteriodLinePosition
{
	public Vector2 LeftRange;		//the range of the left asteriod's position
	public float AsteriodInstance;	//the distance between two asteriods
	public float YPos;				//the Y position of the spawn position
	public float SpawnIntervalSeconds = 2f;
}

public class AsteriodSpawn : MonoBehaviour {
	public GameObject[] Asteriods;
	public GameObject[] LineAsteriods;
	public AsteriodPosition myAsteriodPosition;
	public AsteriodLinePosition myAsteriodLine;
	private System.Random rnd = new System.Random();
	//randomly spawn asteriods for 20 times
	public IEnumerator SpawnRandom()
	{
		for (int k = 0; k < 20; k++) {
			Vector3 newPosition = new Vector3 (Random.Range (myAsteriodPosition.XMinMax.x, myAsteriodPosition.XMinMax.y), myAsteriodPosition.YPos, 0f);
			GameObject asteriod = Instantiate (Asteriods [rnd.Next (0, Asteriods.Length - 1)], newPosition, Quaternion.Euler (new Vector3 (0f, 0f, 0f)));
			asteriod.SetActive (true);
			yield return new WaitForSeconds (myAsteriodPosition.SpawnIntervalSeconds);
		}
	}
	//spawn asteriod line for 10 times
	public IEnumerator SpawnAsteriodLine()
	{
		for (int k = 0; k < 10; k++) {
			GameObject myAsteriod = LineAsteriods [rnd.Next (0, LineAsteriods.Length - 1)];
			for (float x = Random.Range (myAsteriodLine.LeftRange.x, myAsteriodLine.LeftRange.y), temp = x + myAsteriodLine.AsteriodInstance * 4; x <= temp; x += myAsteriodLine.AsteriodInstance) {
				Vector3 newPosition = new Vector3 (x, myAsteriodLine.YPos, 0f);
				GameObject asteriod = Instantiate (myAsteriod, newPosition, myAsteriod.transform.rotation);
				asteriod.SetActive (true);
			}
			yield return new WaitForSeconds (myAsteriodLine.SpawnIntervalSeconds);
		}
	}
}