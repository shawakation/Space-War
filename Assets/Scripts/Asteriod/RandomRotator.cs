using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
	public Vector2 TumbleRange;
	void Start()
	{
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * Random.Range (TumbleRange.x, TumbleRange.y);
	}
}