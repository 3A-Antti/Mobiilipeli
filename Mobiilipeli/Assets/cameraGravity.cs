using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraGravity : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;

	void Update()
	{
		transform.position = new Vector3
		(
			Mathf.Clamp(target.position.x, -22f, 7f),
			Mathf.Clamp(target.position.y, -3f, 25f),
			transform.position.z
		);
	}
}
