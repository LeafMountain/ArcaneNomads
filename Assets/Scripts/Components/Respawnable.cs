using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Respawnable : MonoBehaviour {

	public Vector3 spawnPoint;
	public UnityEvent OnRespawn;

	void Start(){
		if(spawnPoint == Vector3.zero){
			spawnPoint = transform.position;
		}
	}

	public void Respawn(){
		OnRespawn.Invoke();
		transform.position = spawnPoint;
	}

	public void SetSpawnPoint(Vector3 spawnPoint){
		this.spawnPoint = spawnPoint;
	}
}
