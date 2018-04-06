using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Health : MonoBehaviour {

    public IntVariable currentHealth;
    public IntReference maxHealth;
    public bool resetOnPlay = true;

    public UnityEvent OnDamaged;
    public UnityEvent OnHealed;
    public UnityEvent OnNoHealth;

    void Start(){
        if(!currentHealth){
            // currentHealth = new FloatVariable();
            currentHealth = ScriptableObject.CreateInstance<IntVariable>();
            currentHealth.name = gameObject.name + " HP";
        }
        currentHealth.SetValue(maxHealth.Value);
    }

    public void ModifyHealth(int amount) {

        currentHealth.ApplyChange(amount);

        if(amount > 0){
            OnHealed.Invoke();
        } else{
            OnDamaged.Invoke();
        }

        if (currentHealth.Value <= 0){
            currentHealth.SetValue(0);
            OnNoHealth.Invoke();
        }
    }
}
