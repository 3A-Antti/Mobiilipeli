using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getkeyMovement : MonoBehaviour
{
    public float speed   = 0f;
    float r_speed = 2f;
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
        if (L_isHeldDown || R_isHeldDown)
        {
            Debug.Log("L_isHeldDown || R_isHeldDown");
        }

        lastInterval = Time.realtimeSinceStartup;

        if (speed < 0)
        {
            speedText.text = "0";
        } else {
            speedText.text = speed.ToString();
        }
    }

    void FixedUpdate()
    {
        //print(speed);
        //print(lastInterval);

        /*float z     = Input.GetAxis("Horizontal") * r_speed * Time.deltaTime,
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
        }*/

        if (L_isHeldDown && r_speed < 4)
        {
            r_speed += 0.04f;
        } 
        else 
        if (!L_isHeldDown && r_speed > 2)
        {
            r_speed -= 0.025f;
        }

        if (R_isHeldDown && r_speed < 4)
        {
            r_speed += 0.04f;
        } 
        else 
        if (!R_isHeldDown && r_speed > 2)
        {
            r_speed -= 0.025f;
        }

        transform.position += transform.up * Time.deltaTime * speed;
        // rivi 104 liikuttaa alusta koko ajan eteenpäin,
        // mutta alus ei kuitenkaan liiku, jos speed on 0

        if (speed > 0) 
        {
            speed = speed - 0.005f;
        }

        if (L_isHeldDown == true && R_isHeldDown == true/*Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)*/)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }
        }
        else
        if (/*Input.GetKey(KeyCode.A)*/L_isHeldDown == true /*&& (limit < 90 || dcheck90_270 == false)*/)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            transform.Rotate(0, 0, r_speed);     
        }
        else
        if (/*Input.GetKey(KeyCode.D)*/R_isHeldDown == true /*&& (limit > 270 || dcheck90_270 == true )*/)
        {
            if (speed < 1.5)
            {
                speed = speed + 0.075f;
            }

            transform.Rotate(0, 0, -r_speed);     
        }

        if ((L_isHeldDown || R_isHeldDown) && wallcheck && speed < 4)
        {
            speed = speed + 0.025f;
        } 
 
        if (!wallcheck && speed > 1.5)
        {
            speed = speed - 0.0035f;
        }
    }
    
    // OnTriggerEnter2D (rivi 158) ja
    // OnTriggerExit2D (rivi 164) molemmat kutsutaan
    // vain kerran per niitten toteutumis ehtojen
    // mukaan. Funktiot on unityyn sisään rakennettuja,
    // eikä käyttäjän määrittämiä

    private void OnTriggerEnter2D(Collider2D other)
    { // funktio kutsutaan triggerin aktivoinnin yhteydessä
        wallcheck = true;

        //print("Trigger Entered");
    }

    void OnTriggerExit2D(Collider2D other)
    { // funktio kutsutaan kun triggeri menee pois päältä
        wallcheck = false;
        
        //print("Trigger Exited");
    }
}
