using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    private Transform Playercar;
    private float yOffset=2.5f;
	private float zOffset=30f;
	private float xOffset =1f;

	void Start()
    {
		Playercar = GameObject.Find("Playercar").transform;

	}

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(Playercar.position.x + xOffset, Playercar.position.y + yOffset, Playercar.position.z + zOffset);
    }
}
