using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Physics.gravity = new Vector3(2f, 0, 0);    
        print("Trigger Entered");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Physics.gravity = new Vector3(0, 0, 0);
        print("Trigger Exited");
    }
}
