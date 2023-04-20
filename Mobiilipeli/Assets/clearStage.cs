using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class clearStage : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene("mainMenu");
	}
}
