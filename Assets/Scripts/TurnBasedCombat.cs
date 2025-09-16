using UnityEngine;

public class TurnBasedCombat : MonoBehaviour
{
    Weapons weapons;

    public GameObject player;
    public GameObject enemy;

    Entity entityscript;

    Entity enemyentity = new Entity();

    public bool isAttacking;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TakeTurn();
    }

    void TakeTurn()
    {
        isAttacking = true;
        
        if (entityscript.currentHealth <= 0)
        {
            entityscript.Die();
            isAttacking = false;
        }
        else
        {
            entityscript.Attack(enemyentity);
            isAttacking = false;
        }
        
    }
}
