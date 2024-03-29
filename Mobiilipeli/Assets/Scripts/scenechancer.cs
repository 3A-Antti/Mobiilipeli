using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;

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

    public void Click(bool tutOver)
    {
        if(tutOver)
        {
            SceneManager.LoadScene("flashlightlevel");
        }
        
        if(EventSystem.current.currentSelectedGameObject.name == "tutorial_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("SampleScene");
        }

        if(EventSystem.current.currentSelectedGameObject.name == "darkness_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("flashlightlevel");
        }

        if(EventSystem.current.currentSelectedGameObject.name == "gravity_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("gravitylevel");
        }

        if(EventSystem.current.currentSelectedGameObject.name == "end_stage")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("credits_scene");
        }

        if(EventSystem.current.currentSelectedGameObject.name == "pause")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("mainMenu");
        }
    }

    public void doExitGame() 
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying=false;
        #endif

        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}