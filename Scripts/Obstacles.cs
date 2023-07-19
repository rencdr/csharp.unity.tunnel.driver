using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
	public GameObject[] objectsToSpawn; 
	public GameObject roadPrefab; 
	public Transform[] spawnPoints; 
	public float spawnInterval = 1f; 
	public float despawnDelay = 6f; 

	private List<GameObject> spawnedObjects = new List<GameObject>(); 

	void Start()
	{
		StartCoroutine(SpawnObjects());
	}

	IEnumerator DespawnObjects(GameObject spawnedObject)
	{
		yield return new WaitForSeconds(despawnDelay);
		spawnedObjects.Remove(spawnedObject);
		Destroy(spawnedObject);
	}

	IEnumerator SpawnObjects()
	{
		while (true)
		{
			GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

			Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

			GameObject spawnedObject = Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);

			spawnedObjects.Add(spawnedObject);

			StartCoroutine(DespawnObjects(spawnedObject));

			yield return new WaitForSeconds(spawnInterval);
		}
	}
}






