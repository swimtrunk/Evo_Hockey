using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    //Circle rotation variables
    float timeCounter = 0f;
    int timeRounded;
    public int durationTime;

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
        spriteToUse = powerUpSprites[Random.Range(0, powerUpSprites.Length)];
        powerUp.GetComponent<SpriteRenderer>().sprite = spriteToUse;
        powerUpGrabScript = powerUp.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        if (timeRounded % durationTime == 0 && timeRounded > 0)
        {
            powerUp.SetActive(true);
        }

        if (powerUpGrabScript.powerGrabbed)
        {
            //Give Power Up
            powerUpGrabScript.powerGrabbed = false;
        }

        //Circle rotation handling
        timeCounter += Time.deltaTime;
        timeRounded = Mathf.RoundToInt(timeCounter);
        x = Mathf.Cos(timeCounter) * radius;
        y = Mathf.Sin(timeCounter) * radius;

        powerUp.transform.position = new Vector3(x, y, z);
    }

}
