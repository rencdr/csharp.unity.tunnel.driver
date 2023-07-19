using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmanager : MonoBehaviour
{
	public Button retryBut;
	public Button quitBut;
	public void OnRetryButtonClicked()
	{
		SceneManager.LoadScene("SampleScene");
	}
	public void QuitButtonClicked()
	{
		Application.Quit();
	}

	
}
