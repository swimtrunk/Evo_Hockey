using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evo : MonoBehaviour
{
    public GameObject wallObject;
    public GameObject puckWithScript;
    public GameObject playerWithScript;
    public GameObject enemy2WithScript;
    public GameObject enemy3WithScript;
    public GameObject enemy4WithScript;

    public GameObject crosshairObject;
    public int playerInControl;

    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;

    private Vector2 p1StartPos;
    private Vector2 p2StartPos;
    private Vector2 p3StartPos;
    private Vector2 p4StartPos;

    private Vector3 originalSize;

    public Vector3 lowerScaleEvoSize = new Vector3(0.1f, 0.1f, 1f);
    public Vector3 higherScaleEvoSize = new Vector3(0.3f, 0.3f, 1f);

    public float EvoDuration = 5;
    [SerializeField] private float EvoDurationChange;
    private bool EvoTimer = false;
    private bool ScaleEvoUsed = false;
    private bool WallEvoUsed = false;
    private bool PinpointEvoUsed = false;

    WhichGoal whichGoalScript;
    PlayerMovement playerMovementScript;
    EnemyMovement enemyMovementScript2;
    EnemyMovement enemyMovementScript3;
    EnemyMovement enemyMovementScript4;

    void Start()
    {
        p1StartPos = player1.position;
        p2StartPos = player2.position;
        p3StartPos = player3.position;
        p4StartPos = player4.position;

        EvoDurationChange = EvoDuration;
        originalSize = player1.localScale;

        whichGoalScript = puckWithScript.GetComponent<WhichGoal>();

        enemyMovementScript2 = enemy2WithScript.GetComponent<EnemyMovement>();
        enemyMovementScript3 = enemy3WithScript.GetComponent<EnemyMovement>();
        enemyMovementScript4 = enemy4WithScript.GetComponent<EnemyMovement>();

        playerMovementScript = playerWithScript.GetComponent<PlayerMovement>();
    }

    void ScaleEvo()
    {
        if (whichGoalScript.p1GoalHits == 5 && ScaleEvoUsed == false)
        {
            player1.localScale = higherScaleEvoSize;
            player2.localScale = lowerScaleEvoSize;
            player3.localScale = lowerScaleEvoSize;
            player4.localScale = lowerScaleEvoSize;
            ScaleEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p2GoalHits == 5 && ScaleEvoUsed == false)
        {
            player1.localScale = lowerScaleEvoSize;
            player2.localScale = higherScaleEvoSize;
            player3.localScale = lowerScaleEvoSize;
            player4.localScale = lowerScaleEvoSize;
            ScaleEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p3GoalHits == 5 && ScaleEvoUsed == false)
        {
            player1.localScale = lowerScaleEvoSize;
            player2.localScale = lowerScaleEvoSize;
            player3.localScale = higherScaleEvoSize;
            player4.localScale = lowerScaleEvoSize;
            ScaleEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p4GoalHits == 5 && ScaleEvoUsed == false)
        {
            player1.localScale = lowerScaleEvoSize;
            player2.localScale = lowerScaleEvoSize;
            player3.localScale = lowerScaleEvoSize;
            player4.localScale = higherScaleEvoSize;
            ScaleEvoUsed = true;
            EvoTimer = true;
        }
    }

    void RemoveScaleEvo()
    {
        player1.localScale = originalSize;
        player2.localScale = originalSize;
        player3.localScale = originalSize;
        player4.localScale = originalSize;
    }

    void WallEvo()
    {
        if (whichGoalScript.p1GoalHits == 10 && WallEvoUsed == false)
        {
            EvoDurationChange = 20f;
            wallObject.SetActive(true);
            wallObject.transform.position = p1StartPos;
            WallEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p2GoalHits == 10 && WallEvoUsed == false)
        {
            EvoDurationChange = 20f;
            wallObject.SetActive(true);
            wallObject.transform.position = p2StartPos;
            WallEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p3GoalHits == 10 && WallEvoUsed == false)
        {
            EvoDurationChange = 20f;
            wallObject.SetActive(true);
            wallObject.transform.position = p3StartPos;
            WallEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p4GoalHits == 10 && WallEvoUsed == false)
        {
            EvoDurationChange = 20f;
            wallObject.SetActive(true);
            wallObject.transform.position = p4StartPos;
            WallEvoUsed = true;
            EvoTimer = true;
        }
    }

    void RemoveWallEvo()
    {
        wallObject.SetActive(false);
        EvoDurationChange = EvoDuration;
    }

    void PinpointEvo()
    {
        EvoDuration = EvoDuration / 2;

        if (whichGoalScript.p1GoalHits == 15 && PinpointEvoUsed == false)
        {
            playerMovementScript.moveSpeed = 0;
            playerMovementScript.hitForce = 0;
            enemyMovementScript2.moveSpeed = 0;
            enemyMovementScript2.attackForce = 0;
            enemyMovementScript3.moveSpeed = 0;
            enemyMovementScript3.attackForce = 0;
            enemyMovementScript4.moveSpeed = 0;
            enemyMovementScript4.attackForce = 0;

            crosshairObject.SetActive(true);
            playerInControl = 1;

            PinpointEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p2GoalHits == 15 && PinpointEvoUsed == false)
        {
            playerMovementScript.moveSpeed = 0;
            playerMovementScript.hitForce = 0;
            enemyMovementScript2.moveSpeed = 0;
            enemyMovementScript2.attackForce = 0;
            enemyMovementScript3.moveSpeed = 0;
            enemyMovementScript3.attackForce = 0;
            enemyMovementScript4.moveSpeed = 0;
            enemyMovementScript4.attackForce = 0;

            crosshairObject.SetActive(true);
            playerInControl = 2;

            PinpointEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p3GoalHits == 15 && PinpointEvoUsed == false)
        {
            playerMovementScript.moveSpeed = 0;
            playerMovementScript.hitForce = 0;
            enemyMovementScript2.moveSpeed = 0;
            enemyMovementScript2.attackForce = 0;
            enemyMovementScript3.moveSpeed = 0;
            enemyMovementScript3.attackForce = 0;
            enemyMovementScript4.moveSpeed = 0;
            enemyMovementScript4.attackForce = 0;

            crosshairObject.SetActive(true);
            playerInControl = 3;

            PinpointEvoUsed = true;
            EvoTimer = true;
        }
        else if (whichGoalScript.p4GoalHits == 15 && PinpointEvoUsed == false)
        {
            playerMovementScript.moveSpeed = 0;
            playerMovementScript.hitForce = 0;
            enemyMovementScript2.moveSpeed = 0;
            enemyMovementScript2.attackForce = 0;
            enemyMovementScript3.moveSpeed = 0;
            enemyMovementScript3.attackForce = 0;
            enemyMovementScript4.moveSpeed = 0;
            enemyMovementScript4.attackForce = 0;

            crosshairObject.SetActive(true);
            playerInControl = 4;

            PinpointEvoUsed = true;
            EvoTimer = true;
        }
    }

    void RemovePinpointEvo()
    {
        playerMovementScript.moveSpeed = 0.2f;
        playerMovementScript.hitForce = 10f;
        enemyMovementScript2.moveSpeed = 0.08f;
        enemyMovementScript2.attackForce = 12f;
        enemyMovementScript3.moveSpeed = 0.08f;
        enemyMovementScript3.attackForce = 12f;
        enemyMovementScript4.moveSpeed = 0.08f;
        enemyMovementScript4.attackForce = 12f;

        crosshairObject.SetActive(false);
        playerInControl = 0;
    }

    void Update()
    {

        if (EvoDurationChange < 0.3f)
        {
            EvoTimer = false;

            RemoveScaleEvo();
            RemoveWallEvo();
            RemovePinpointEvo();

            EvoDurationChange = EvoDuration;
        }

        if (EvoTimer == true)
        {
            EvoDurationChange = EvoDurationChange - Time.deltaTime;
        }

        ScaleEvo();
        WallEvo();
        PinpointEvo();

    }

}
