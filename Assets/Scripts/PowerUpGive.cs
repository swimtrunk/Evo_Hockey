using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGive : MonoBehaviour
{
    /* This script handles the Power Up display */

    public GameObject powerUp;
    PowerUpGrab powerUpGrabScript;
    PowerUp powerUpScript;

    public bool powerUpGiven = false;

    //Slot Objects
    public GameObject playerOnePowerOne;
    public GameObject playerOnePowerTwo;
    public GameObject playerOnePowerThree;

    public GameObject playerTwoPowerOne;
    public GameObject playerTwoPowerTwo;
    public GameObject playerTwoPowerThree;

    public GameObject playerThreePowerOne;
    public GameObject playerThreePowerTwo;
    public GameObject playerThreePowerThree;

    public GameObject playerFourPowerOne;
    public GameObject playerFourPowerTwo;
    public GameObject playerFourPowerThree;

    void Start()
    {
        powerUpGrabScript = powerUp.GetComponent<PowerUpGrab>();
        powerUpScript = GetComponent<PowerUp>();
    }

    void Update()
    {
        if (powerUpGrabScript.whoToGive == 1 && powerUpGiven == false)
        {
            //Do thing.
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
