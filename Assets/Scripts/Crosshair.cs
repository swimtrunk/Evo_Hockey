using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private Vector2 mousePos;
    public GameObject puck;
    public float hitMultiplier = 10f;
    public int hitCheck = 0;
    private Rigidbody2D puckRB;
    private Vector2 difference;

    void Start()
    {
        puckRB = puck.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        difference = transform.position - puck.transform.position;

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;

        if ((Input.GetButtonDown("Jump")) && (hitCheck < 3))
        {
            hitCheck += 1;
            puckRB.AddForce(difference * hitMultiplier, ForceMode2D.Impulse);
        }
    }
}
