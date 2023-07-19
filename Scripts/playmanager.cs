using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playmanager : MonoBehaviour
{
	public Button playBut;
	public void OnPlayButtonClicked()
	{
		SceneManager.LoadScene("SampleScene");
	}
}
