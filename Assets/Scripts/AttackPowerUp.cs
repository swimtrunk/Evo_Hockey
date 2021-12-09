using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : MonoBehaviour
{
    public GameObject playerOneAttack;
    public GameObject playerTwoAttack;
    public GameObject playerThreeAttack;
    public GameObject playerFourAttack;

    public Sprite attackSprite;
    public GameObject powerUpObject;
    PowerUpGrab powerUpGrabScript;

    void Start()
    {
        powerUpGrabScript = powerUpObject.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        if (powerUpGrabScript.powerUpSprite == attackSprite)
        {
            if (powerUpGrabScript.whoToGive == 1)
            {
                playerOneAttack.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 2)
            {
                playerTwoAttack.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 3)
            {
                playerThreeAttack.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
            else if (powerUpGrabScript.whoToGive == 4)
            {
                playerFourAttack.GetComponent<SpriteRenderer>().sprite = powerUpGrabScript.powerUpSprite;
            }
        }
    }
}
