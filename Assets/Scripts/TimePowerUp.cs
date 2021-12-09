using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePowerUp : MonoBehaviour
{
    public GameObject playerOneTime;
    public GameObject playerTwoTime;
    public GameObject playerThreeTime;
    public GameObject playerFourTime;

    public Sprite timeSprite;
    public GameObject powerUpObject;
    PowerUpGrab powerUpGrabScript;

    void Start()
    {
        powerUpGrabScript = powerUpObject.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        if (powerUpGrabScript.powerUpSprite == timeSprite)
        {
            if (powerUpGrabScript.whoToGive == 1)
            {
                playerOneTime.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 2)
            {
                playerTwoTime.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 3)
            {
                playerThreeTime.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 4)
            {
                playerFourTime.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
        }
    }
}
