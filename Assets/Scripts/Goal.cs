using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private LayerMask puckMask;
    public Transform Puck;
    public GameObject PuckObject;
    private Rigidbody2D PckRB;
    public GameObject objectWithEvoScript;

    Evo evoScript;
    WhichContact whichContactScript;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    public Vector2 Player1PuckSpwn = new Vector2(-2f, 2f);
    public Vector2 Player2PuckSpwn = new Vector2(-2f, -2f);
    public Vector2 Player3PuckSpwn = new Vector2(2f, 2f);
    public Vector2 Player4PuckSpwn = new Vector2(2f, -2f);

    public Transform puckSpawnPos;

    public GameObject Scoreboard;
    ScoreKeeper scoreKeeperScript;

    public int goalNumber;

    //Awards players points if you hit the puck into your own goal
    void EvalSelfScore()
    {
        if (whichContactScript.previousHit == Player1)
        {
            scoreKeeperScript.playerOneScore += 1;
            puckSpawnPos.position = Player1PuckSpwn;
        }
        else if (whichContactScript.previousHit == Player2)
        {
            scoreKeeperScript.playerTwoScore += 1;
            puckSpawnPos.position = Player2PuckSpwn;
        }
        else if (whichContactScript.previousHit == Player3)
        {
            scoreKeeperScript.playerThreeScore += 1;
            puckSpawnPos.position = Player3PuckSpwn;
        }
        else if (whichContactScript.previousHit == Player4)
        {
            scoreKeeperScript.playerFourScore += 1;
            puckSpawnPos.position = Player4PuckSpwn;
        }
        else
        {
            Debug.Log("The weird thing happened.");
            puckSpawnPos.position = new Vector2(0, 1);
        }
    }

    void Start()
    {
        whichContactScript = PuckObject.GetComponent<WhichContact>();
        PckRB = PuckObject.GetComponent<Rigidbody2D>();
        scoreKeeperScript = Scoreboard.GetComponent<ScoreKeeper>();
        evoScript = objectWithEvoScript.GetComponent<Evo>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 6)
        {

            //Goal1
            if (evoScript.playerInControl == 1 && goalNumber != 1)
            {
                puckSpawnPos.position = Player1PuckSpwn;
                scoreKeeperScript.playerOneScore += 1;
            }

            if (evoScript.playerInControl == 0)
            {
                if (goalNumber == 1 && whichContactScript.whichPlayerCollided == 1 && whichContactScript.recentHit == whichContactScript.previousHit)
                {
                    puckSpawnPos.position = Player1PuckSpwn;
                }
                else if (goalNumber != 1 && whichContactScript.whichPlayerCollided == 1)
                {
                    puckSpawnPos.position = Player1PuckSpwn;
                    scoreKeeperScript.playerOneScore += 1;
                }
                else if (goalNumber == 1 && whichContactScript.whichPlayerCollided == 1)
                {
                    if (whichContactScript.previousHit != whichContactScript.recentHit)
                    {
                        EvalSelfScore();
                    }
                }
            }

            //Goal2
            if (evoScript.playerInControl == 2 && goalNumber != 2)
            {
                puckSpawnPos.position = Player2PuckSpwn;
                scoreKeeperScript.playerTwoScore += 1;
            }

            if (evoScript.playerInControl == 0)
            {
                if (goalNumber == 2 && whichContactScript.whichPlayerCollided == 2 && whichContactScript.recentHit == whichContactScript.previousHit)
                {
                    puckSpawnPos.position = Player2PuckSpwn;
                }
                else if (goalNumber != 2 && whichContactScript.whichPlayerCollided == 2)
                {
                    puckSpawnPos.position = Player2PuckSpwn;
                    scoreKeeperScript.playerTwoScore += 1;
                }
                else if (goalNumber == 2 && whichContactScript.whichPlayerCollided == 2)
                {
                    if (whichContactScript.previousHit != whichContactScript.recentHit)
                    {
                        EvalSelfScore();
                    }
                }
            }

            //Goal3
            if (evoScript.playerInControl == 3 && goalNumber != 3)
            {
                puckSpawnPos.position = Player3PuckSpwn;
                scoreKeeperScript.playerThreeScore += 1;
            }

            if (evoScript.playerInControl == 0)
            {
                if (goalNumber == 3 && whichContactScript.whichPlayerCollided == 3 && whichContactScript.recentHit == whichContactScript.previousHit)
                {
                    puckSpawnPos.position = Player3PuckSpwn;
                }
                else if (goalNumber != 3 && whichContactScript.whichPlayerCollided == 3)
                {
                    puckSpawnPos.position = Player3PuckSpwn;
                    scoreKeeperScript.playerThreeScore += 1;
                }
                else if (goalNumber == 3 && whichContactScript.whichPlayerCollided == 3)
                {
                    if (whichContactScript.previousHit != whichContactScript.recentHit)
                    {
                        EvalSelfScore();
                    }
                }
            }

            //Goal4
            if (evoScript.playerInControl == 4 && goalNumber != 4)
            {
                puckSpawnPos.position = Player4PuckSpwn;
                scoreKeeperScript.playerFourScore += 1;
            }

            if (evoScript.playerInControl == 0)
            {
                if (goalNumber == 4 && whichContactScript.whichPlayerCollided == 4 && whichContactScript.recentHit == whichContactScript.previousHit)
                {
                    puckSpawnPos.position = Player4PuckSpwn;
                }
                else if (goalNumber != 4 && whichContactScript.whichPlayerCollided == 4)
                {
                    puckSpawnPos.position = Player4PuckSpwn;
                    scoreKeeperScript.playerFourScore += 1;
                }
                else if (goalNumber == 4 && whichContactScript.whichPlayerCollided == 4)
                {
                    if (whichContactScript.previousHit != whichContactScript.recentHit)
                    {
                        EvalSelfScore();
                    }
                }
            }

            //Puck Reset
            PckRB.velocity = new Vector2(0, 0);
            Puck.position = puckSpawnPos.position;

        }
    }

}
