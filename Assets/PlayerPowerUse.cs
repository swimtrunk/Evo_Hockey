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

   void Update()
    {
        if (attackPower.GetComponent<SpriteRenderer>().sprite == attackPowerSprite && Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackPower.GetComponent<SpriteRenderer>().sprite = emptyPower;
            Debug.Log("Attack Power Activated.");
            //Do Attack Power
        }

        if (stealPower.GetComponent<SpriteRenderer>().sprite == stealPowerSprite && Input.GetKeyDown(KeyCode.Alpha2))
        {
            stealPower.GetComponent<SpriteRenderer>().sprite = emptyPower;
            Debug.Log("Steal Power Activated.");
            //Do Steal Power
        }

        if (timePower.GetComponent<SpriteRenderer>().sprite == timePowerSprite && Input.GetKeyDown(KeyCode.Alpha3))
        {
            timePower.GetComponent<SpriteRenderer>().sprite = emptyPower;
            Debug.Log("Time Power Activated.");
            //Do Time Power
        }
    }

}
