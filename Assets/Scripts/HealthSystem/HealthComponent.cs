using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class HealthComponent : MonoBehaviour, IDamageable
{
    public int maxHealth;
    public int currentHealth;

    public UnityEvent OnHit;
    public UnityEvent OnDead;

    public void AdjustHealth(int value)
    {
        currentHealth += value;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if (currentHealth == 0)
            OnDead.Invoke();
    }

    public void Hit(Weapon instagator, int value)
    {
        AdjustHealth(value);
        OnHit.Invoke();
    }

    void Start()
    {
        currentHealth = maxHealth;
    }
}
