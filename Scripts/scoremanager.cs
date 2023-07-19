using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoremanager : MonoBehaviour
{
	public Text scoreText; 

	private float score; 

	void Start()
	{
		score = 0f; 
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		score += Time.deltaTime;

		scoreText.text = "Score: " + Mathf.Round(score).ToString() + "km ";
	}
}
