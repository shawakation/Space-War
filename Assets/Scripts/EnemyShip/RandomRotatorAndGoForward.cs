using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotatorAndGoForward : MonoBehaviour {
	public float RotationSpeed = 10f;
	public float UpSpeed = 10f;
	public int health = 10;
	public int ScoreValue = 100;
	public GameObject Explosion;
	public Score myScore;
	void Start ()
	{
		Rigidbody myEnemyShip = GetComponent<Rigidbody> ();
		myEnemyShip.angularVelocity = new Vector3 (0f, RotationSpeed, 0f);
		myEnemyShip.velocity = new Vector3 (0f, -UpSpeed, 0f);
	}
	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag) {
		case "Shot":
			{
				if (health == 0) {
					Instantiate (Explosion, this.transform.position, Explosion.transform.rotation);
					myScore.AddScore (ScoreValue);
					Destroy (this.gameObject);
				} else
					health--;
				break;
			}
		}
	}
}