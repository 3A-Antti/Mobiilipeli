using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getkeyMovement : MonoBehaviour
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
        Debug.Log("toimii");
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

        //speedText.text = speed.ToString();
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

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
        }
        else
        if (Input.GetKey(KeyCode.A)/*L_isHeldDown == true*/ /*&& (limit < 90 || dcheck90_270 == false)*/)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, 1.75f);     
        }
        else
        if (Input.GetKey(KeyCode.D)/*R_isHeldDown == true*/ /*&& (limit > 270 || dcheck90_270 == true )*/)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, -1.75f);     
        }

        /*if (Input.GetKey(KeyCode.S) && speed > 0)
        {
            speed = speed - 0.005f;
        } 

        if (Input.GetKey(KeyCode.W) && speed < 5)
        {
            speed = speed + 0.005f;
        }*/

        if (wallcheck == true && speed < 4)
        {
            speed = speed + 0.025f;
        } 
 
        if (wallcheck == false && speed > 1.5)
        {
            speed = speed - 0.0035f;
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
