using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyComponent : MonoBehaviour {

	[HideInInspector]
	public NavMeshAgent agent;

	public float speed;
}
