using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float speed   = 5f;
    float r_speed = 90;

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;    // tää liikuttaa alusta koko ajan eteenpäin.
                                                                        // tän voi siirtää if lauseen sisälle jos haluaa
                                                                        // että alus ei mee koko ajan eteenpäin, mutta
                                                                        // sen kanssa on semmonen pikku bugi, että kun 
                                                                        // painaa a ja d samaan aikaan, niin alus kulkee
                                                                        // kaks kertaa nopeemmin.

        float z = Input.GetAxis("Horizontal") * r_speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A) && !(Input.GetKey(KeyCode.D)))
        {
            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, z);     // tässä kohtaa alus/pelaaja kääntyy
            //Debug.Log(z);
            //Debug.Log("a"); 
        }

        if (Input.GetKey(KeyCode.D)  && !(Input.GetKey(KeyCode.A)))
        {
            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, z);     
            //Debug.Log(z);
            //Debug.Log("d");
        }

        if (Input.GetKey(KeyCode.S) && speed > 0)
        {
            speed = speed - 0.005f;
        } 

        if (Input.GetKey(KeyCode.W) && speed < 5)
        {
            speed = speed + 0.005f;
        }
    }
}
