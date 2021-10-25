using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichContact : MonoBehaviour
{
    //For contact checks
    public GameObject previousHit;
    public GameObject recentHit;
    public int whichPlayerCollided = 0;

    void OnCollisionEnter2D (Collision2D col)
    {

        //Handles Current Contact
        if (col.gameObject.tag == "Player1")
        {
            previousHit = recentHit;
            recentHit = col.gameObject;
            whichPlayerCollided = 1;
        }

        if (col.gameObject.tag == "Player2")
        {
            previousHit = recentHit;
            recentHit = col.gameObject;
            whichPlayerCollided = 2;
        }
        
        if (col.gameObject.tag == "Player3")
        {
            previousHit = recentHit;
            recentHit = col.gameObject;
            whichPlayerCollided = 3;
        }
        
        if (col.gameObject.tag == "Player4")
        {
            previousHit = recentHit;
            recentHit = col.gameObject;
            whichPlayerCollided = 4;
        }
    }

}
