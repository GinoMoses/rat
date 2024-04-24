using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    [SerializeField] FloatingHealthbar healthbar;

    private void Awake() {
        healthbar = GetComponentInChildren<FloatingHealthbar>();
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.UpdateHealthBar(currentHealth, maxHealth);
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthbar.UpdateHealthBar(currentHealth, maxHealth);
        if(currentHealth <= 0)
        {
            // I ain't coding a death for a test enemy lmao
            Debug.Log("Enemy ded");
        }
    }

}
