using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class Weapon : MonoBehaviour
{
    [Header("Gun")]
    public float firerate = .5f;
    public int numberOfBullets = 1;
    [Tooltip("Distance before bullet is destroyed")] public float range = 10;

    [Header("Bullet")]
    [Tooltip("m/s")] public float bulletSpeed = 10;
    [Tooltip("In degrees")] public float bulletSpread = 0;
    public int bulletDamage = 1;

    [Header("Other")]
    public GameObject bulletPrefab;
    public Transform shootOrigin;
    public UnityEvent OnFire;

    bool onCooldown;

    public void Fire()
    {
        if (!onCooldown)
            StartCoroutine(InternalFire());
    }

    public void Reload()
    {
        Debug.Log("Reloading");
    }

    void Start()
    {
        if (!bulletPrefab) Debug.LogWarning("Bullet prefab missing.");
        if (!shootOrigin) Debug.LogWarning("Shoot origin missing.");
    }

    IEnumerator InternalFire()
    {
        onCooldown = true;

        for (int i = 0; i < numberOfBullets; i++)
        {
            Bullet bullet = Instantiate(bulletPrefab, shootOrigin.position, shootOrigin.rotation).GetComponent<Bullet>();
            Collider bulletCollider = bullet.GetComponent<Collider>();
            Vector3 bulletDirection = shootOrigin.forward;
            // bulletDirection =
            bullet.Init(bulletDamage, bulletSpeed, bulletDirection, this);  
            Destroy(bullet.gameObject, range / bulletSpeed);  
        }

        OnFire.Invoke();
        yield return new WaitForSeconds(firerate / 1);
        onCooldown = false;
    }

    void OnDrawGizmosSelected()
    {
        Vector3 coneDirection = shootOrigin.forward * range;
        Gizmos.DrawRay(transform.position, coneDirection);
        Handles.DrawCone(0, shootOrigin.position, shootOrigin.rotation, bulletSpeed);
    }
}
