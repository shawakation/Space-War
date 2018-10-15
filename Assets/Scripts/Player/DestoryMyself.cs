using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMyself : MonoBehaviour {
	public GameObject PlayerExplosion;
	public GameOver theGameOver;
	public int health = 20;
	private Animator myAnimator;
	void Start()
	{
		myAnimator = GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag) {
		case "Asteriod":
			{
				if (health <= 0) {
					Instantiate<GameObject> (PlayerExplosion, other.transform.position, other.transform.rotation);
					theGameOver.gameOverProcess ();
					Destroy (this.gameObject);
				} else {
					health -= 3;
					myAnimator.Play ("vehicle_playerShip");
				}
				break;
			}
		case "EnemyRollingShip":
			{
				health = 0;
				Instantiate<GameObject> (PlayerExplosion, other.transform.position, other.transform.rotation);
				theGameOver.gameOverProcess ();
				Destroy (this.gameObject);
				break;
			}
		case "EnemyShip":
			{
				if (health <= 0) {
					Instantiate<GameObject> (PlayerExplosion, other.transform.position, other.transform.rotation);
					theGameOver.gameOverProcess ();
					Destroy (this.gameObject);
				} else {
					health -= 5;
					myAnimator.Play ("vehicle_playerShip");
				}
				break;
			}
		case "EnemyShot":
			{
				if (health <= 0) {
					Instantiate<GameObject> (PlayerExplosion, other.transform.position, other.transform.rotation);
					theGameOver.gameOverProcess ();
					Destroy (this.gameObject);
				} else {
					health -= 1;
					myAnimator.Play ("vehicle_playerShip");
				}
				break;
			}
		}
	}
	public void WudiMode()
	{
		GetComponent<MeshCollider> ().enabled = false;
	}
	public void NormalMode()
	{
		GetComponent<MeshCollider> ().enabled = true;
	}
}