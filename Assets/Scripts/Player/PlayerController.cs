using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the boundary of player
[System.Serializable]
public struct Boundary
{
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
}

public class PlayerController : MonoBehaviour {
	public Boundary theBoundary;
	public float SpeedScale = 5f;
	public float tilt = 4f;
	public float FireRate = 1f;
	public GameObject Shot;
	public Transform ShootPosition;
	private float nextfire = 0.0f;
	void Update()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextfire) {
			nextfire = Time.time + FireRate;
			Instantiate<GameObject> (Shot, ShootPosition.position, Shot.transform.rotation);
			GetComponent<AudioSource> ().Play ();
		}
	}
	void FixedUpdate()
	{
		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0f);
		Rigidbody thePlayerRigid = GetComponent<Rigidbody> ();
		thePlayerRigid.velocity = movement * SpeedScale;
		Vector3 thePosition = thePlayerRigid.position;
		thePlayerRigid.position = new Vector3 (Mathf.Clamp (thePosition.x, theBoundary.xMin, theBoundary.xMax), Mathf.Clamp (thePosition.y, theBoundary.yMin, theBoundary.yMax), 0f);
		thePlayerRigid.rotation = Quaternion.Euler (new Vector3 (-90f, thePlayerRigid.velocity.x * -tilt, 0f));
	}
}
