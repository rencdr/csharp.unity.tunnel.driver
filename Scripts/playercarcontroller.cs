using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercarmovement : MonoBehaviour
{
	public float initialSpeed = 10f; 
	public float accelerationRate = 0.5f; 
	private float currentSpeed; 
	public float xMinLimit = -2.5f;
	public float xMaxLimit = 7f;
	public SpawnManager spawnManager;

	void Start()
	{
		currentSpeed = initialSpeed;
	}

	void Update()
	{
		currentSpeed += accelerationRate * Time.deltaTime;
		float hMovement = Input.GetAxis("Horizontal") * currentSpeed;

		transform.Translate(new Vector3(hMovement, 0, 0) * Time.deltaTime);

		transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

		float clampedX = Mathf.Clamp(transform.position.x, xMinLimit, xMaxLimit);
		transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

	}
	private void OnTriggerEnter(Collider other)
	{
		//Debug.Log("Etkileþime giren nesne: " + other.gameObject.name);
		if (other.CompareTag("SpawnPoint"))
		{
			//Debug.Log("Spawn noktasýna ulaþýldý.");
			spawnManager.SpawnTriggerEnter();
		}
		if (other.CompareTag("car"))
		{
			//Debug.Log("Araç baþka bir araçla çarpýþtý.");
			SceneManager.LoadScene("GameOverScene");

		}
		if (other.CompareTag("spawncube"))
		{
			//Debug.Log("spawnroad");
			spawnManager.SpawnTriggerEnter();
		}
		
		
	}
	
	


}

