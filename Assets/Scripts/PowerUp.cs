using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    //Circle rotation variables
    float timeCounter = 0f;

    float x = 0f;
    float y = 0f;
    float z = 0f;

    public float radius = 3f;

    //Power up variables
    public Sprite[] powerUpSprites;

    public GameObject powerUp;
    PowerUpGrab powerUpGrabScript;

    void Start()
    {
        powerUpGrabScript = powerUp.GetComponent<PowerUpGrab>();
    }

    void Update()
    {
        if (powerUpGrabScript.powerGrabbed)
        {
            //Give Power Up
            powerUpGrabScript.powerGrabbed = false;
        }

        //Circle rotation handling
        timeCounter += Time.deltaTime;
        x = Mathf.Cos(timeCounter) * radius;
        y = Mathf.Sin(timeCounter) * radius;

        powerUp.transform.position = new Vector3(x, y, z);
    }

}
