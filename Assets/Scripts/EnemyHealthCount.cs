using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthCount : MonoBehaviour
{
    [SerializeField] private Text healthcount;

    public void UpdateHealthCount(float currentHealth, float maxHealth)
    {
        healthcount.text = currentHealth.ToString() + "/" + maxHealth.ToString();
    }
}
