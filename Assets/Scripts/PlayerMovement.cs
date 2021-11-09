using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 mousePos;
    private Vector2 difference;
    public GameObject puck;
    public GameObject paddle;
    private Rigidbody2D puckRB;
    private Rigidbody2D paddleRB;
    public float moveSpeed = 0.1f;
    public float hitForce = 100f;
    private bool isMoving;

    Vector2 position = new Vector2(0f, 0f);

    void Start()
    {
        paddleRB = paddle.GetComponent<Rigidbody2D>();
        puckRB = puck.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x < 20f && mousePos.x > -20f && mousePos.y < 20f && mousePos.y > -20f)
        {
            if (Input.GetButton("Fire1"))
            {
                isMoving = true;
                position = Vector2.Lerp(transform.position, mousePos, moveSpeed);
            }

            paddleRB.velocity = new Vector2(0, 0);
        }

        difference = puck.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            paddleRB.MovePosition(position);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            FindObjectOfType<AudioManager>().Play("Hit");
            puckRB.AddForce(difference * hitForce, ForceMode2D.Impulse);
        }
    }
}
