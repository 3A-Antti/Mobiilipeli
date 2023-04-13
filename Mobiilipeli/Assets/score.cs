using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScore;

    float storevalue1;// = GameObject.Find("PLAYER").GetComponent<getkeyMovement>().speed;

    int hitCount = 0;

    void Start()
    { // Start kutsutaan ennen ekaa frame päivitystä
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }

    void Update()
    { // Update kutsutaan kerran per frame
        storevalue1 = GameObject.Find("PLAYER").GetComponent<getkeyMovement>().speed;

        //Debug.Log(storevalue1);
    }

    private void enterData()
    {
        /*if (storevalue1 < 3)
        {
            hitCount++;
        }*/

        hitCount++;

        scoreText.text = hitCount.ToString();

        if (hitCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", hitCount);
            highScore.text = hitCount.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   // OnTriggerEnter2D kutsutaan triggerin aktivoinnin yhteydessä.
        enterData();
    }

    private void OnTriggerExit2D(Collider2D other)
    {   // OnTriggerExit2D kutsutaan kun trigger menee pois päältä
        
    }
}
