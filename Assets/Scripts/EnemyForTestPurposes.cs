using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public EnemyHealthCount healthcount;

    private void Awake() {
        healthcount = GetComponentInChildren<EnemyHealthCount>();
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthcount.UpdateHealthCount(currentHealth, maxHealth);
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthcount.UpdateHealthCount(currentHealth, maxHealth);
        if(currentHealth <= 0)
        {
            // I ain't coding a death for a test enemy lmao
            Debug.Log("Enemy ded");
        }
    }

}
