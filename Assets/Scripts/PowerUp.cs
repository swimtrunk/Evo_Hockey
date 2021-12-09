using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    /* This script handles the modifcations and movement of the Power Up */

    //Circle rotation variables
    [HideInInspector] public float timeCounter = 0f;
    public int timeRounded;
    public int durationTime;
    bool canChangeSprite = true;

    float x = 0f;
    float y = 0f;
    float z = 0f;

    public float radius = 3f;

    //Power up variables
    public Sprite[] powerUpSprites;
    Sprite spriteToUse;

    public GameObject powerUp;
    PowerUpGrab powerUpGrabScript;

    void Start()
    {
        powerUpGrabScript = powerUp.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        //Circle rotation handling
        timeCounter += Time.deltaTime;
        timeRounded = Mathf.RoundToInt(timeCounter);
        x = Mathf.Cos(timeCounter) * radius;
        y = Mathf.Sin(timeCounter) * radius;

        powerUp.transform.position = new Vector3(x, y, z);

        //Puck interaction and power up swap handling
        if (powerUp.activeSelf == false)
        {
            canChangeSprite = true;
        }

        if (timeRounded % durationTime == 0 && timeRounded > 0 && canChangeSprite)
        {
            ChangeSprite();
            powerUp.SetActive(true);
        }

        if (powerUpGrabScript.powerGrabbed)
        {
            powerUpGrabScript.powerGrabbed = false;
        }
    }

    void ChangeSprite()
    {
        spriteToUse = powerUpSprites[Random.Range(0, powerUpSprites.Length)];
        powerUp.GetComponent<SpriteRenderer>().sprite = spriteToUse;
        canChangeSprite = false;
    }

}
