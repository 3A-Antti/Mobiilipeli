using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public Transform target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        transform.position = new Vector3(-1000f, 1000f, 1000f);

        if(other.gameObject.tag == "Player")
        {
            target.transform.Rotate(0, 0, -180f);
        }
    }
}
