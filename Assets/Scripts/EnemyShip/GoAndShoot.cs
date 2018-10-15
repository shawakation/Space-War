using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAndShoot : MonoBehaviour {
	public float Speed = 3f;
	public Vector2 ShotInterval;
	public Transform ShotPosition;
	public GameObject EnemyShot;
	public GameObject Explosion;
	public int health = 5;
	public int ScoreValue;
	public Score myScore;
	void Start()
	{
		GetComponent<Rigidbody> ().velocity = new Vector3 (0f, -Speed, 0f);
		StartCoroutine (Shoot ());
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
		case "Player":
			{
				Instantiate (Explosion, this.transform.position, Explosion.transform.rotation);
				myScore.AddScore (ScoreValue);
				Destroy (this.gameObject);
				break;
			}
		}
	}
	IEnumerator Shoot()
	{
		while (true) {
			yield return new WaitForSeconds (Random.Range (ShotInterval.x, ShotInterval.y));
			Instantiate<GameObject> (EnemyShot, ShotPosition.position, EnemyShot.transform.rotation);
			GetComponent<AudioSource> ().Play ();
		}
	}
}