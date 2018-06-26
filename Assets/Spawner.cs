using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public int amount;
	public GameObject prefab;
	public Vector3 area;

	void Start ()
	{
		for (int i = 0; i < amount; i++)
		{
			Instantiate (prefab, new Vector3 (Random.Range (-area.x / 2, area.x / 2), area.y, Random.Range (-area.y / 2, area.y / 2)), Quaternion.identity);
		}
	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.DrawWireCube (transform.position, area);
	}
}