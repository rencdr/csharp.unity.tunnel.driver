using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawn roadSpawner;
    
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawn>();    
    }

    public void SpawnTriggerEnter()
    {
        roadSpawner.MoveRoad();
    }

    
    void Update()
    {
        
    }
}
