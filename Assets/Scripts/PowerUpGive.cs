using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGive : MonoBehaviour
{
    /* This script handles the Power Up display */

    public GameObject powerUp;
    PowerUpGrab powerUpGrabScript;

    public bool powerUpGiven = false;

    void Start()
    {
        powerUpGrabScript = powerUp.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        if (powerUpGrabScript.whoToGive == 1 && powerUpGiven == false)
        {
            Debug.Log("Giving Player 1 the ability.");
            powerUpGiven = true;
        }
        else if (powerUpGrabScript.whoToGive == 2 && powerUpGiven == false)
        {
            Debug.Log("Giving Player 2 the ability.");
            powerUpGiven = true;
        }
        else if (powerUpGrabScript.whoToGive == 3 && powerUpGiven == false)
        {
            Debug.Log("Giving Player 3 the ability.");
            powerUpGiven = true;
        }
        else if (powerUpGrabScript.whoToGive == 4 && powerUpGiven == false)
        {
            Debug.Log("Giving Player 4 the ability.");
            powerUpGiven = true;
        }
    }
}
