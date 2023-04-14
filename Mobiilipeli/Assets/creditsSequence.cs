using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditsSequence : MonoBehaviour
{
    bool moveUp = false;
    float speed = 50f;

    void FixedUpdate()
    {
        if (moveUp == true)
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        moveUp = true;
        print("Trigger Entered");
    }
}
