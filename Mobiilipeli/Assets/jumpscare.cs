using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public Transform thisObject;
    public Transform target;
    
    float gkmSpeed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        

        if(other.gameObject.tag == "Player")
        {
            target.transform.Rotate(0, 0, -180f);
        }

        gkmSpeed = GameObject.Find("PLAYER").GetComponent<getkeyMovement>().speed;
    }
}
