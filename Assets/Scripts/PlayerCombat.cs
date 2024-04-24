using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerCombat : MonoBehaviour
{
    
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemeyLayers;

    public float damage = 40;

    // 'leveling' system
    public int level = 1;
    public int strLevel = 1;
    public int dexLevel = 1;
    public int intLevel = 1;

    void Start() {
        // only for debugging and showcasing purposes
        attackPoint.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(Attack());
        }
    }

    private IEnumerator Attack()
    {
        // TODO: Animate this one day

        float damageMultiplier = 1 + (level * 0.25f) - 0.25f;

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemeyLayers);

        attackPoint.GetComponent<SpriteRenderer>().enabled = true;

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyTest>().TakeDamage(damage * damageMultiplier);
        }

        yield return new WaitForSeconds(0.3f);
        attackPoint.GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
