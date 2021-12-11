using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUse : MonoBehaviour
{
    public GameObject attackPower;
    public GameObject stealPower;
    public GameObject timePower;

    public Sprite emptyPower;
    public Sprite attackPowerSprite;
    public Sprite stealPowerSprite;
    public Sprite timePowerSprite;

    public float powerTimeDuration;
    private float powerDeltaTime;
    private bool powerUsed;

    //For Attack Power Up
    public GameObject player;
    PlayerMovement playerMovementScript;

    //For Steal Power Up
    public Transform puck;
    private Rigidbody2D puckRB;

    //For Time Power Up
    public GameObject playerTwo;
    public GameObject playerThree;
    public GameObject playerFour;

    /*PlayerMovement already defined*/
    EnemyMovement paddleTwoMovementScript;
    EnemyMovement paddleThreeMovementScript;
    EnemyMovement paddleFourMovementScript;


    void Start()
    {
        puckRB = puck.GetComponent<Rigidbody2D>();
        playerMovementScript = player.GetComponent<PlayerMovement>();

        paddleTwoMovementScript = playerTwo.GetComponent<EnemyMovement>();
        paddleThreeMovementScript = playerThree.GetComponent<EnemyMovement>();
        paddleFourMovementScript = playerFour.GetComponent<EnemyMovement>();
    }

    void Update()
    {
        if (powerDeltaTime < powerTimeDuration && powerUsed == true)
        {
            powerDeltaTime += Time.deltaTime;
        }
        else
        {
            RemovePowers();
            powerUsed = false;
            powerDeltaTime = 0;
        }

        if (attackPower.GetComponent<SpriteRenderer>().sprite == attackPowerSprite && Input.GetKeyDown(KeyCode.Alpha1) && powerUsed == false)
        {
            attackPower.GetComponent<SpriteRenderer>().sprite = emptyPower;
            Debug.Log("Attack Power Activated.");
            AttackPower();
            powerUsed = true;
        }

        if (stealPower.GetComponent<SpriteRenderer>().sprite == stealPowerSprite && Input.GetKeyDown(KeyCode.Alpha2))
        {
            stealPower.GetComponent<SpriteRenderer>().sprite = emptyPower;
            Debug.Log("Steal Power Activated.");
            StealPower();
            powerUsed = true;
        }

        if (timePower.GetComponent<SpriteRenderer>().sprite == timePowerSprite && Input.GetKeyDown(KeyCode.Alpha3))
        {
            timePower.GetComponent<SpriteRenderer>().sprite = emptyPower;
            Debug.Log("Time Power Activated.");
            TimePower();
            powerUsed = true;
        }
    }

    void AttackPower()
    {
        playerMovementScript.hitMultiplier = 2.5f;
    }

    void StealPower()
    {
        puckRB.velocity = new Vector2(0, 0);
        puck.position = new Vector2(-2, 2);
    }

    void TimePower()
    {
        paddleTwoMovementScript.speedMultiplier = 0.25f;
        paddleThreeMovementScript.speedMultiplier = 0.25f;
        paddleFourMovementScript.speedMultiplier = 0.25f;
    }

    void RemovePowers()
    {
        paddleTwoMovementScript.speedMultiplier = 1f;
        paddleThreeMovementScript.speedMultiplier = 1f;
        paddleFourMovementScript.speedMultiplier = 1f;

        playerMovementScript.hitMultiplier = 1f;
    }

}
