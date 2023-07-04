using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareTrigger_lvl2 : MonoBehaviour
{
    int triggerCount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Player")
        {
            if(triggerCount < 1)
            {
                triggerCount++;

                transform.Rotate(0, 0, -90f);
                transform.position = new Vector3(-3.05f, 10.82f, 0.0f);
            }
        }
    }
}
