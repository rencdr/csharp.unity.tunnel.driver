
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public List<GameObject> roads;
    private float offset = 30f;
    void Start()
    {
        if( roads != null && roads.Count>0 )
        {
            roads=roads.OrderBy(r=>r.transform.position.z).ToList();
        }
    }

	public void MoveRoad()
	{
		GameObject movedRoad = roads[0];
		roads.RemoveAt(0);
		float newZ = roads[roads.Count - 1].transform.position.z + offset;
		movedRoad.transform.position = new Vector3(0, 0, newZ);
		roads.Add(movedRoad);
	}

	/*
    public void MoveRoad()
    {
        GameObject movedRoad = roads[0];
        roads.Remove(movedRoad);
        float newZ = roads[roads.Count - 1].transform.position.z + offset;
        movedRoad.transform.position = new Vector3(0, 0, newZ);
        roads.Add(movedRoad);   
    }
    */
}
