using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class scenechancer : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        if(EventSystem.current.currentSelectedGameObject.name == "tutorial_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene(0);
        }

        if(EventSystem.current.currentSelectedGameObject.name == "darkness_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene(1);
        }

        if(EventSystem.current.currentSelectedGameObject.name == "gravity_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene(2);
        }

        if(EventSystem.current.currentSelectedGameObject.name == "end_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene(3);
        }

        if(EventSystem.current.currentSelectedGameObject.name == "pause")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene(4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}