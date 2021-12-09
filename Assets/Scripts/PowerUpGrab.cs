using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGrab : MonoBehaviour
{
    /* This script handles the puck interaction with the Power Up */

    public GameObject powerUp;

    public bool powerGrabbed;
    public int whoToGive;

    public GameObject puck;
    WhichContact whichContactScript;

    public GameObject paddleOne;
    public GameObject paddleTwo;
    public GameObject paddleThree;
    public GameObject paddleFour;

    public GameObject powerSpawner;
    PowerUp powerUpScript;
    public Sprite powerUpSprite;

    void Start()
    {
        whichContactScript = puck.GetComponent<WhichContact>();
        powerUpScript = powerSpawner.GetComponent<PowerUp>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 6)
        {
            powerUpScript.timeCounter = 0;
            HandleWhoToGive();
            powerUpSprite = powerUp.GetComponent<SpriteRenderer>().sprite;
            powerUp.SetActive(false);
            powerGrabbed = true;
        }
    }

    void HandleWhoToGive()
    {
        if (whichContactScript.recentHit == paddleOne)
        {
            whoToGive = 1;
        }
        else if (whichContactScript.recentHit == paddleTwo)
        {
            whoToGive = 2;
        }
        else if (whichContactScript.recentHit == paddleThree)
        {
            whoToGive = 3;
        }
        else if (whichContactScript.recentHit == paddleFour)
        {
            whoToGive = 4;
        }
    }

}
