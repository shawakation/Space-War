using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {
	public GameObject AsteriodExplosion;
	public int ScoreValue;
	public int health = 5;
	public Score theScore;
	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag) {
		case "Player":
			{
				Instantiate<GameObject> (AsteriodExplosion, this.transform.position, AsteriodExplosion.transform.rotation);
				theScore.AddScore (ScoreValue);
				Destroy (this.gameObject);
				break;
			}
		case "Shot":
			{
				if (health == 0) {
					Instantiate<GameObject> (AsteriodExplosion, this.transform.position, AsteriodExplosion.transform.rotation);
					theScore.AddScore (ScoreValue);
					Destroy (this.gameObject);
				} else
					health--;
				break;
			}
		case "Asteriod":
			{
				Instantiate<GameObject> (AsteriodExplosion, this.transform.position, AsteriodExplosion.transform.rotation);
				Destroy (this.gameObject);
				break;
			}
		}
	}
}