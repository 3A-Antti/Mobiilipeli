using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour
{
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }

    public void Click()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
