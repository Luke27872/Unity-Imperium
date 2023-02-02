using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShootDirection : MonoBehaviour
{
    public PlayerController playerController;

    public Button UpArrow;
    public Button DownArrow;
    public Button LeftArrow;
    public Button RightArrow;
    public Button UpRightArrow;
    public Button DownRightArrow;
    public Button UpLeftArrow;
    public Button DownLeftArrow;

    public void Up()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(0f, 10f, 0f);
            UpArrow.image.color = Color.green;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void Down()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(0f, -10f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.green;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void Left()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(-10f, 0f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.green;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void Right()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(10f, 0f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.green;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void UpRight()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(10f, 10f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.green;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void DownRight()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(10f, -10f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.green;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void UpLeft()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(-10f, 10f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.green;
            DownLeftArrow.image.color = Color.white;
        }
    }

    public void DownLeft()
    {
        if (playerController.playerCanShoot == false)
        {
            playerController.projectileDirection.transform.localPosition = new Vector3(-10f, -10f, 0f);
            UpArrow.image.color = Color.white;
            DownArrow.image.color = Color.white;
            LeftArrow.image.color = Color.white;
            RightArrow.image.color = Color.white;
            UpRightArrow.image.color = Color.white;
            DownRightArrow.image.color = Color.white;
            UpLeftArrow.image.color = Color.white;
            DownLeftArrow.image.color = Color.green;
        }
    }
}
