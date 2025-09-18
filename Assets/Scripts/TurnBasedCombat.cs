using UnityEngine;

public class TurnBasedCombat : MonoBehaviour
{
    public Entity player;   
    public Entity enemy; 

    bool playerTurn = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeTurn();
        }
    }

    void TakeTurn()
    {
        if (playerTurn)
        {
            // player attacks enemy
            player.Attack(enemy);
        }
        else
        {
            // enemy attacks player
            enemy.Attack(player);
        }

        // switch turn
        playerTurn = !playerTurn;
        
    }
}
