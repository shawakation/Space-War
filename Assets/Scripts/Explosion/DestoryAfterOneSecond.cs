using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAfterOneSecond : MonoBehaviour {
	public float AfterSeconds = 2f;
	void Start () 
	{
		Destroy (this.gameObject, AfterSeconds);
	}
}
