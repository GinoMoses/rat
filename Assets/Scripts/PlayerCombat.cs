using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerCombat : MonoBehaviour
{
    
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemeyLayers;

    public int damage = 40;

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

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemeyLayers);

        attackPoint.GetComponent<SpriteRenderer>().enabled = true;

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyTest>().TakeDamage(damage);
        }

        yield return new WaitForSeconds(1);
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
