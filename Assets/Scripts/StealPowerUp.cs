using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealPowerUp : MonoBehaviour
{
    public GameObject playerOneSteal;
    public GameObject playerTwoSteal;
    public GameObject playerThreeSteal;
    public GameObject playerFourSteal;

    public Sprite stealSprite;
    public GameObject powerUpObject;
    PowerUpGrab powerUpGrabScript;

    void Start()
    {
        powerUpGrabScript = powerUpObject.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        if (powerUpGrabScript.powerUpSprite == stealSprite)
        {
            if (powerUpGrabScript.whoToGive == 1)
            {
                playerOneSteal.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 2)
            {
                playerTwoSteal.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 3)
            {
                playerThreeSteal.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 4)
            {
                playerFourSteal.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
        }
    }
}
