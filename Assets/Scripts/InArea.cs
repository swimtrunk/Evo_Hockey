using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InArea : MonoBehaviour
{

    public bool isInArea;

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.layer == 6)
        {
            isInArea = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.layer == 6)
        {
            isInArea = false;
        }
    }

}
