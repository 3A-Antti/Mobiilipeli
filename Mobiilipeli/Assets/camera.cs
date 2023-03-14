using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update ()
    {
        transform.position = new Vector3
        (
            Mathf.Clamp(target.position.x, -20f, 20f),
            Mathf.Clamp(target.position.y, -6, 19f),
            transform.position.z
        );
    }

    /*private void LateUpdate()
    {
        transform.position = target.position;
    }*/
}
