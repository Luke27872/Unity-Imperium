using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public PlayerController playerController;
    public EnemyController[] enemies;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            playerController.playerCanMove = false;

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].ActivateEnemies();
            }
        }

        if (collision.tag == "Wall")
        {
            playerController.playerCanShoot = false;

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].ActivateEnemies();
            }
        }
    }
}