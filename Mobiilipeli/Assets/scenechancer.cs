using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class scenechancer : MonoBehaviour
{
    public GameObject Button;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}