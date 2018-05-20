using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float lifetime;
	public float damage;

	public UnityGameObjectEvent OnCollision;

	public void SetLifetime(float lifetime){
		this.lifetime = lifetime;
		StartCoroutine(DestroyMe());		
	}

	public void SetDamage(float damage){
		this.damage = damage;
	}

	IEnumerator DestroyMe(){
		yield return new WaitForSeconds(lifetime);
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider col){
		if(!col.GetComponent<Bullet>()){
			OnCollision.Invoke(gameObject);
		}
	}
}
