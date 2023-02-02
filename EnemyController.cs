using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 enemyPos;
    public float enemyPosX;
    public float enemyPosY;
    public bool enemyCanMove = false;
    public bool calculateMove = true;
    public Transform movePoint;
    public float moveSpeed = 2f;
    public int enemyMoveCount = 0;
    public int enemyMoveDistance = 1;
    public bool enemyCanShoot = false;
    public Transform projectile;
    public Transform projectileDirection;
    public float projectileSpeed = 10f;
    public bool hit = false;

    public PlayerController playerController;
    public PlayerDamage playerDamage;
    public GameObject player;
    public float playerPosX;
    public float playerPosY;

    public int rng;
    public LayerMask stopMovement;

    
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        
        enemyPos = transform.position;

        if (enemyCanMove == true)
        {
            if (enemyMoveCount < enemyMoveDistance)
            {
                CalculateMoveDirection();
            }

            if (Vector3.Distance(transform.position, movePoint.position) == 0f)
            {
                enemyCanMove = false;
                enemyMoveCount = 0;
                CalculateProjectileDirection();
                enemyCanShoot = true;
            }
        }

        if (enemyCanShoot == true)
        {
            projectile.transform.position = Vector3.MoveTowards(projectile.transform.position, projectileDirection.position, projectileSpeed * Time.deltaTime);
        }

        if (hit == true)
        {
            enemyCanShoot = false;
            hit = false;
            projectile.transform.position = enemyPos;
            playerController.playerCanMove = true;
        }
    }

    void CalculateMoveDirection()
    {
        while (calculateMove == true)
        {
            rng = Random.Range(1, 5);

            if (rng == 1)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, 1.5f, 0f), .2f, stopMovement))
                {
                    movePoint.position += new Vector3(0f, 1.5f, 0f);
                    calculateMove = false;
                }
            }
            else if (rng == 2)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(1.5f, 0f, 0f), .2f, stopMovement))
                {
                    movePoint.position += new Vector3(1.5f, 0f, 0f);
                    calculateMove = false;
                }
            }
            else if (rng == 3)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, -1.5f, 0f), .2f, stopMovement))
                {
                    movePoint.position += new Vector3(0f, -1.5f, 0f);
                    calculateMove = false;
                }
            }
            else if (rng == 4)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(-1.5f, 0f, 0f), .2f, stopMovement))
                {
                    movePoint.position += new Vector3(-1.5f, 0f, 0f);
                    calculateMove = false;
                }
            }
        }
        enemyMoveCount++;
        calculateMove = true; ;
    }

    void CalculateProjectileDirection()
    {
        enemyPosX = enemy.transform.position.x;
        enemyPosY = enemy.transform.position.y;

        playerPosX = player.transform.position.x;
        playerPosY = player.transform.position.y;

        if (enemyPosX == playerPosX && enemyPosY < playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(0f, 10f, 0f);
        }
        else if (enemyPosX < playerPosX && enemyPosY < playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(10f, 10f, 0f);
        }
        else if (enemyPosX < playerPosX && enemyPosY == playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(10f, 0f, 0f);
        }
        else if (enemyPosX < playerPosX && enemyPosY > playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(10f, -10f, 0f);
        }
        else if (enemyPosX == playerPosX && enemyPosY > playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(0f, -10f, 0f);
        }
        else if (enemyPosX > playerPosX && enemyPosY > playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(-10f, -10f, 0f);
        }
        else if (enemyPosX > playerPosX && enemyPosY == playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(-10f, 0f, 0f);
        }
        else if (enemyPosX > playerPosX && enemyPosY < playerPosY)
        {
            projectileDirection.transform.localPosition = new Vector3(-10f, 10f, 0f);
        }
    }

    public void ActivateEnemies()
    {
        enemyCanMove = true;
    }
}