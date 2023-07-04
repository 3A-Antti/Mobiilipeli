using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savedata : MonoBehaviour
{	
    public scoreboard Scoreboard = new scoreboard();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            SaveToJson();
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            LoadFromJson();
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            
        }
    }

    public void SaveToJson()
    {
        string inventoryData = JsonUtility.ToJson(Scoreboard);
        string filePath = Application.persistentDataPath+"/InventoryData.json";
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, inventoryData);
        Debug.Log("vittu saatana");
    }
    
    public void LoadFromJson()
    {
        string filePath = Application.persistentDataPath+"/InventoryData.json";
        string inventoryData = System.IO.File.ReadAllText(filePath);

        Scoreboard = JsonUtility.FromJson<scoreboard>(inventoryData);
        Debug.Log("ranskalaiset syödään ketsupilla");  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
    }

    [System.Serializable]
    public class scoreboard
    {
        public int score;
        public bool levelC;
    }
}

