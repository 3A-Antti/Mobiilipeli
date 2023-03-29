using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void enterData()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   // funktio kutsutaan triggerin aktivoinnin yhteydessä.
        enterData();
    }

    private void OnTriggerExit2D(Collider2D other)
    {   // funktio kutsutaan kun trigger menee pois päältä
        
    }
}
