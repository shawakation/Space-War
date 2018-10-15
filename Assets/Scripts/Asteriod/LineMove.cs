using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMove : MonoBehaviour {
	public float InitialSpeed = -8f;
	void Start ()
	{
		GetComponent<Rigidbody> ().velocity = new Vector3 (0f, InitialSpeed, 0f);
	}
}