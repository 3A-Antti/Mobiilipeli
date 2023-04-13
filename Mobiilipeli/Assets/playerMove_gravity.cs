using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove_gravity : MonoBehaviour
{
    float speed   = 0f;
    float r_speed = 90;
    float z; 

    public bool L_isHeldDown = false,
                R_isHeldDown = false,
                wallcheck    = false,
                dcheck90_270,
                inputcheck;

    private Rigidbody2D rb2D;

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

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        print(speed);

        rb2D.velocity = Vector3.zero;

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
            speed = speed - 0.01f;
        }

        if (L_isHeldDown == true && R_isHeldDown == true/*Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)*/)
        {
            inputcheck = true;

            if (speed < 0.15)
            {
                speed = speed + 0.05f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
        }
        else
        if (/*Input.GetKey(KeyCode.A)*/L_isHeldDown == true /*&& (limit < 90 || dcheck90_270 == false)*/)
        {
            inputcheck = true;

            if (speed < 0.15)
            {
                speed = speed + 0.05f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, 1.5f);     
        }
        else
        if (/*Input.GetKey(KeyCode.D)*/R_isHeldDown == true /*&& (limit > 270 || dcheck90_270 == true )*/)
        {
            inputcheck = true;

            if (speed < 0.15)
            {
                speed = speed + 0.05f;
            }

            //transform.position += transform.up * Time.deltaTime * speed;
            transform.Rotate(0, 0, -1.5f);     
        }

        if (inputcheck == false)
        {
            transform.Rotate(0, 0, 0);
        }

        /*if (Input.GetKey(KeyCode.S) && speed > 0)
        {
            speed = speed - 0.005f;
        } 

        if (Input.GetKey(KeyCode.W) && speed < 5)
        {
            speed = speed + 0.005f;
        }*/

        if (wallcheck == true && speed < 5 && (R_isHeldDown == true || L_isHeldDown == true))
        {
            speed = speed + 0.05f;
        } 
 
        if (wallcheck == false && speed > 1)
        {
            speed = speed - 0.05f;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        wallcheck = true;
        print("Trigger Entered");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        wallcheck = false;
        print("Trigger Exited");
    }
}