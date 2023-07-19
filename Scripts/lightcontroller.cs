using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lightcontroller : MonoBehaviour
{
	private Transform Playercar;
	

	void Start()
	{
		Playercar = GameObject.Find("Playercar").transform;

	}

	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = new Vector3(Playercar.position.x , Playercar.position.y , Playercar.position.z);
	}
}

