using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;
using Unity.VisualScripting;

public class restartScene : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("foo");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
