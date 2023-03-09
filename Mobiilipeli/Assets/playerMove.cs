using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float speed   = 5f;
    float r_speed = 90;
    float z; 

    public bool L_isHeldDown = false;
    public bool R_isHeldDown = false;

    public void L_onPress ()
    {
        L_isHeldDown = true;
        //Debug.Log(L_isHeldDown);
    }
 
    public void L_onRelease ()
    {
        L_isHeldDown = false;
        //Debug.Log(L_isHeldDown);
    }

    public void R_onPress ()
    {
        R_isHeldDown = true;
        //Debug.Log(R_isHeldDown);
    }
 
    public void R_onRelease ()
    {
        R_isHeldDown = false;
        //Debug.Log(R_isHeldDown);
    }

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;    // tää liikuttaa alusta koko ajan eteenpäin.
                                                                        // tän voi siirtää if lauseen sisälle jos haluaa
                                                                        // että alus ei mee koko ajan eteenpäin, mutta
                                                                        // sen kanssa on semmonen pikku bugi, että kun 
                                                                        // painaa a ja d samaan aikaan, niin alus kulkee
                                                                        // kaks kertaa nopeemmin.

        float z = Input.GetAxis("Horizontal") * r_speed * Time.deltaTime;

        

        if (L_isHeldDown == true)
        {
            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, 0.1f);     
        }

        if (R_isHeldDown == true)
        {
            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, -0.1f);     
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

    public void moveLeft() 
    {
        transform.Rotate(0, 0, 0.1f);     // tässä kohtaa alus/pelaaja kääntyy

        //z = Input.GetAxis("Horizontal") * r_speed * Time.deltaTime;
        //Debug.Log("moveLeft() toimii");
        //transform.position += transform.up * Time.deltaTime * speed;
        //Debug.Log(z);
        //Debug.Log("a"); 
    }


}
