using UnityEngine;
using System.Collections;

public class ShotMoveAndExplode : MonoBehaviour
{
	public float ShotSpeed = 10f;
	public GameObject ShotExplosion;
	void Start ()
	{
		this.GetComponent<Rigidbody> ().velocity = Vector3.up * ShotSpeed;
	}
	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag) {
		case "EnemyShip":
			{
				Instantiate<GameObject> (ShotExplosion, this.transform.position, ShotExplosion.transform.rotation);
				Destroy (this.gameObject);
				break;
			}
		case "EnemyRollingShip":
			{
				Instantiate<GameObject> (ShotExplosion, this.transform.position, ShotExplosion.transform.rotation);
				Destroy (this.gameObject);
				break;
			}
		case "Asteriod":
			{
				Instantiate<GameObject> (ShotExplosion, this.transform.position, ShotExplosion.transform.rotation);
				Destroy (this.gameObject);
				break;
			}
		}
	}
}