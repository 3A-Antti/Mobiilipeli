using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxScript : MonoBehaviour
{
    public AudioSource boom;

    public void playBoom()
    {
        boom.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   // OnTriggerEnter2D kutsutaan triggerin aktivoinnin yhteydessä.
        playBoom();
    }
}
