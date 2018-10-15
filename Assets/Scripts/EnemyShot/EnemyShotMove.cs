using UnityEngine;
using System.Collections;

public class EnemyShotMove : MonoBehaviour
{
	public float ShotSpeed = 10f;
	void Start ()
	{
		this.GetComponent<Rigidbody> ().velocity = Vector3.down * ShotSpeed;
	}
	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag) {
		case "Player":
			{
				Destroy (this.gameObject);
				break;
			}
		case "Asteriod":
			{
				Destroy (this.gameObject);
				break;
			}
		}
	}
}