using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerController playerController;
    public EnemyController enemyController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerController.playerHealth = playerController.playerHealth - 25;
            enemyController.hit = true;
        }

        if (collision.tag == "Wall")
        {
            enemyController.hit = true;
        }
    }
}
