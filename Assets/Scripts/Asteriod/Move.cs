using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Vector2 XMinMax;
	public Vector2 YMinMax;
	void Start ()
	{
		GetComponent<Rigidbody> ().velocity = new Vector3 (Random.Range (XMinMax.x, XMinMax.y), Random.Range (YMinMax.x, YMinMax.y), 0f);
	}
}
