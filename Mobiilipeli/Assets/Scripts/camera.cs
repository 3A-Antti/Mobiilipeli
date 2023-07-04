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
            Mathf.Clamp(target.position.x, -1000f/*-39.57f*/, 1000f/*-39.57f*/),
            Mathf.Clamp(target.position.y, -1000f/*5.5f*/, 1000f/*9.4f*/),
            transform.position.z
        );
    }
}
