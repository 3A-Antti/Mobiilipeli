using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCredits : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;

	void Update()
	{
		transform.position = new Vector3
		(
			Mathf.Clamp(target.position.x, -24f, -2.5f),
			Mathf.Clamp(target.position.y, 0f, 29.5f),
			transform.position.z
		);
	}
}
