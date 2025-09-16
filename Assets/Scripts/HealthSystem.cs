using UnityEngine;

public class Entity : MonoBehaviour
{
    public Weapons weapon;

    public string entityName;
    public int currentHealth;
    public int maxHealth;
    public int damage;

    private void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        damage = weapon.damage;

        Debug.Log(weapon.name);
        Debug.Log(weapon.damage);
    }

    public void Attack(Entity target)
    {
        target.TakeDamage(damage);
        Debug.Log("attacked entity");
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("entity took damage");
    }

    public void Die()
    {
        Destroy(gameObject);
        Debug.Log("entity is dead!");
    }
}
