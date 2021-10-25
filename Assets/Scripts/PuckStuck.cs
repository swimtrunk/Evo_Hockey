using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckStuck : MonoBehaviour
{
    public GameObject goalWithScript;
    public GameObject puckWithScript;
    public GameObject playerTwo;
    public GameObject playerThree;
    public GameObject playerFour;
    WhichContact whichContactScript;
    Goal goalScript;

    [SerializeField] private Transform puckTransform;
    private bool isStuck = false;
    [SerializeField] private float stuckTimer = 10f;
    public float stuckDuration = 10f;

    void Start()
    {
        whichContactScript = puckWithScript.GetComponent<WhichContact>();
        goalScript = goalWithScript.GetComponent<Goal>();
    }

    void Update()
    {
        if (isStuck)
        {
            stuckTimer = stuckTimer - Time.deltaTime;
        }

        if (stuckTimer <= 0.1f)
        {
            if (whichContactScript.recentHit == playerTwo)
            {
                puckTransform.position = goalScript.Player2PuckSpwn;
                stuckTimer = stuckDuration;
            }
            else if (whichContactScript.recentHit == playerThree)
            {
                puckTransform.position = goalScript.Player3PuckSpwn;
                stuckTimer = stuckDuration;
            }
            else if (whichContactScript.recentHit == playerFour)
            {
                puckTransform.position = goalScript.Player4PuckSpwn;
                stuckTimer = stuckDuration;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            isStuck = true;
        }
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            isStuck = false;
            stuckTimer = stuckDuration;
        }
    }
}
