using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorApeRotator : MonoBehaviour
{
    public Transform GameObject;
    public Transform text1;
    public Transform text2;
    public Transform text3;
    public Transform text4;

    

    float currentAngle;
    bool alternateFlipflop = false;
    bool nextText1 = false;
    bool nextText2 = false;
    bool nextScene = false;

    public float flipflopSpeed = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, flipflopSpeed);

        currentAngle = GameObject.eulerAngles.z;

        if (currentAngle < 91 && currentAngle >= 0)
        {
            alternateFlipflop = true;
        }

        if (currentAngle < 359  && currentAngle > 270)
        {
            alternateFlipflop = false;
        }

        if (currentAngle >= 45f && alternateFlipflop)
        {
            flipflopSpeed = -1f;
        }

        if (currentAngle <= 315f && !alternateFlipflop)
        {
            flipflopSpeed = 1f;
        }
    }

    public void ClickTextBox()
    {
        if (!nextText1)
        {
            Vector3 tempPosition     = text1.transform.position;
            text1.transform.position = text2.transform.position;
            text2.transform.position = tempPosition;

            nextText1 = true;
        } 
        else if (nextText1 != nextText2)
        {
            Vector3 tempPosition     = text2.transform.position;
            text2.transform.position = text3.transform.position;
            text3.transform.position = tempPosition;

            nextText2 = true;
        }
        else if ((nextText1 == nextText2) && !nextScene)
        {
            Vector3 tempPosition     = text3.transform.position;
            text3.transform.position = text4.transform.position;
            text4.transform.position = tempPosition;

            nextScene = true;
            //print("foo");
        }
        else if (nextScene)
        {
            print("foo");
            SceneManager.LoadScene("flashlightlevel");
        }
    }
}
