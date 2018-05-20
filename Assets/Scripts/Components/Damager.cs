using UnityEngine;
using System.Collections;


public class Damager : MonoBehaviour {

    [SerializeField]
    int damage;
    public UnityGameObjectEvent OnDamage;

    public void Damage (GameObject go)
    {
        if(go.GetComponent<Health>()){
            go.GetComponent<Health>().ModifyValue(damage);
            OnDamage.Invoke(gameObject);
        }
    }
}
