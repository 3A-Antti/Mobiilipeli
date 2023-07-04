using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class noLimitMovement : MonoBehaviour
{
    float speed   = 0f;
    float r_speed = 90;
    float z; 

    public TextMeshProUGUI speedText;
    int score;

    public bool L_isHeldDown = false,
                R_isHeldDown = false,
                wallcheck    = false,
                dcheck90_270;

    double lastInterval;

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
        lastInterval = Time.realtimeSinceStartup;

        /*if (speed < 0)
        {
            speedText.text = "0";
        } else {
            speedText.text = speed.ToString();
        }*/
    }

    void FixedUpdate()
    {
        //print(speed);
        //print(lastInterval);

        float z     = Input.GetAxis("Horizontal") * r_speed * Time.deltaTime,
              limit = transform.rotation.eulerAngles.z;

        if (limit < 91 && limit >= 0)
        {
            dcheck90_270 = true;
            //Debug.Log(dcheck90_270);
        }

        if (limit < 359  && limit > 270)
        {
            dcheck90_270 = false;
            //Debug.Log(dcheck90_270);
        }

        transform.position += transform.up * Time.deltaTime * speed;
        // rivi 57 liikuttaa alusta koko ajan eteenpäin.
        // tän voi siirtää if lauseen sisälle jos haluaa
        // että alus ei mee koko ajan eteenpäin, mutta
        // sen kanssa on semmonen pikku bugi, että kun 
        // painaa a ja d samaan aikaan, niin alus kulkee
        // kaks kertaa nopeemmin.    

        if (speed > 0) 
        {
            speed = speed - 0.005f;
        }

        if (L_isHeldDown == R_isHeldDown)
        { // L_isHeldDown == R_isHeldDown, eli toisin sanoen, kun molemmat on true
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
        }
        else
        if (L_isHeldDown)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, 1.75f);     
        }
        else
        if (R_isHeldDown)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, -1.75f);     
        }

        if (wallcheck)
        { // ei ole mitään nopeus rajoituksia koska se on koko kentän pointti
            speed = speed + 0.025f;
        } 
 
        if (!wallcheck)
        { // ei ole mitään nopeus rajoituksia koska se on koko kentän pointti
            //speed = speed - 0.0035f;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        wallcheck = true;
        //print("Trigger Entered");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        wallcheck = false;
        //print("Trigger Exited");
    }
}
