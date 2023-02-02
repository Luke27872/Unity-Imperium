using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPos;
    public int playerHealth = 100;
    public Text displayHealth;
    public bool playerCanMove = true;
    public Transform movePoint;
    public float moveSpeed = 2f;
    public int moveCount = 0;
    public int moveDis = 1;
    public bool playerCanShoot = false;
    public Transform projectile;
    public Transform projectileDirection;
    public float projectileSpeed = 10f;

    public LayerMask stopMovement;


    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        displayHealth.text = playerHealth.ToString();

        if (playerHealth <= 0)
        {
            Destroy(player);
        }

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        playerPos = player.transform.position;

        if (playerCanMove == true)
        {
            if (Vector3.Distance(transform.position, movePoint.position) == 0f)
            {
                if ((Input.GetKeyDown(KeyCode.W)))
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, 1.5f, 0f), .2f, stopMovement))
                    {
                        player.transform.Rotate(0, 0, 0);
                        //projectileDirection.transform.Rotate(0, 0, 0);

                        movePoint.position += new Vector3(0f, 1.5f, 0f);
                        moveCount++;
                    }
                }
                else if ((Input.GetKeyDown(KeyCode.A)))
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(-1.5f, 0f, 0f), .2f, stopMovement))
                    {
                        player.transform.Rotate(0, 0, 90);
                        //projectileDirection.transform.Rotate(0, 0, 0);
                        movePoint.position += new Vector3(-1.5f, 0f, 0f);
                        moveCount++;
                    }
                }
                else if ((Input.GetKeyDown(KeyCode.S)))
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, -1.5f, 0f), .2f, stopMovement))
                    {
                        player.transform.Rotate(0, 0, 180);
                        //projectileDirection.transform.Rotate(0, 0, 0);
                        movePoint.position += new Vector3(0f, -1.5f, 0f);
                        moveCount++;
                    }
                }
                else if ((Input.GetKeyDown(KeyCode.D)))
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(1.5f, 0f, 0f), .2f, stopMovement))
                    {
                        player.transform.Rotate(0, 0, -90);
                        //projectileDirection.transform.Rotate(0, 0, 0);
                        movePoint.position += new Vector3(1.5f, 0f, 0f);
                        moveCount++;
                    }
                }
            } 
        }

        if (moveCount == moveDis && Vector3.Distance(transform.position, movePoint.position) == 0f)
        {
            moveCount = 0;
            playerCanMove = false;
            playerCanShoot = true;
        }

        if (playerCanShoot == true)
        {
            projectile.transform.position = Vector3.MoveTowards(projectile.transform.position, projectileDirection.position, projectileSpeed * Time.deltaTime);
        }
        else
        {
            projectile.transform.position = playerPos;
        }
    }
}