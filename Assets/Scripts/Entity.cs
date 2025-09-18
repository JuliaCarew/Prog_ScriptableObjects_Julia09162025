using TMPro;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public Weapons weapon;       
    public string entityName;
    public int currentHealth;
    public int maxHealth;

    [Header("UI Elements")]
    public TextMeshProUGUI playerHealth;
    public TextMeshProUGUI enemyHealth;

    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
    }

    public void Attack(Entity target)
    {
        // use weapon damage
        int dmg = weapon != null ? weapon.damage : 0;
        target.TakeDamage(dmg);
        Debug.Log($"{entityName} attacked {target.entityName} for {dmg} damage");
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // update UI
        if (entityName == "Player" && playerHealth != null)
            playerHealth.text = $"Player Health: {currentHealth}/{maxHealth}";
        else if (entityName == "Enemy" && enemyHealth != null)
            enemyHealth.text = $"Enemy Health: {currentHealth}/{maxHealth}";

        if (currentHealth <= 0)
            Die();
    }

    public void Die()
    {
        Debug.Log($"{entityName} is dead!");
        Destroy(gameObject);
    }
}