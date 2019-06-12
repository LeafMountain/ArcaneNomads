using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class Weapon : MonoBehaviour
{
    public float firerate = .5f;
    public float bulletSpeed = 10;
    public GameObject bulletPrefab;
    public Transform shootOrigin;
    public int damage;

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

        Bullet bullet = Instantiate(bulletPrefab, shootOrigin.position, shootOrigin.rotation).GetComponent<Bullet>();
        Collider bulletCollider = bullet.GetComponent<Collider>();
        bullet.Init(damage, bulletSpeed, shootOrigin.forward, this);

        OnFire.Invoke();
        yield return new WaitForSeconds(firerate / 1);
        onCooldown = false;
    }
}
