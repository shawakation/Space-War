using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
	public void explosion_destoryed()
	{
		Destroy (this.gameObject);
	}
}
