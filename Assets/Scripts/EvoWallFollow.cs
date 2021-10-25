using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvoWallFollow : MonoBehaviour
{
    private Vector2 targetDirection;
    private float rotation;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        targetDirection = target.position - transform.position;
        rotation = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(180f + rotation, Vector3.forward);
    }
}
