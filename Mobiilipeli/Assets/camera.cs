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
            Mathf.Clamp(target.position.x, -100f/*-39.57f*/, 100f/*-39.57f*/),
            Mathf.Clamp(target.position.y, -100f/*5.5f*/, 100f/*9.4f*/),
            transform.position.z
        );
    }
}
