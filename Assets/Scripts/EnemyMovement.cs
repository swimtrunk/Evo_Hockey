using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Handles orientation (Keeping this just in case)
    public Transform target;
    /*private Vector2 targetDirection; 
    private float rotation;*/

    //Handles attacking perimeter
    [SerializeField] private GameObject attackArea;
    InArea attackAreaScript;

    //Handles puck interaction
    [SerializeField] private GameObject puck;
    private Rigidbody2D puckRB;
    Vector2 difference;
    Vector2 startingPos;
    Vector2 startingPosPlaceholder;
    Vector2 puckLoc;
    Rigidbody2D enemyPaddleRB;
    public float moveSpeed = 0.1f;
    public float attackForce = 10f;
    Vector2 position = new Vector2(7f, 0f);

    void Start()
    {
        attackAreaScript = attackArea.GetComponent<InArea>();
        puckRB = puck.GetComponent<Rigidbody2D>();
        enemyPaddleRB = GetComponent<Rigidbody2D>();
        position = transform.position; //so the paddle doesn't immediately snap to the puck when the game starts 
        startingPosPlaceholder = transform.position;
    }

    void Update()
    {
        difference = puck.transform.position - transform.position;

        /*Handles orientation (Not sure if I'll need this later)
        targetDirection = target.position - transform.position;
        rotation = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(180f + rotation, Vector3.forward);*/

        position = Vector2.Lerp(transform.position, puckLoc, moveSpeed);
        puckLoc = target.position;

        startingPos = Vector2.Lerp(transform.position, startingPosPlaceholder, moveSpeed);
    }

    void FixedUpdate()
    {
        if (attackAreaScript.isInArea)
        {
            enemyPaddleRB.MovePosition(position);
        }
        else
        {
            enemyPaddleRB.MovePosition(startingPos);
            enemyPaddleRB.velocity = new Vector2(0, 0);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            puckRB.AddForce(difference * attackForce, ForceMode2D.Impulse);
        }
    }

}
