using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGrab : MonoBehaviour
{
    public GameObject powerUp;

    public bool powerGrabbed;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 6)
        {
            powerUp.SetActive(false);
            powerGrabbed = true;
        }
    }

}
