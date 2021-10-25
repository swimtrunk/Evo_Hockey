using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHitParticle : MonoBehaviour
{
    public GameObject hitParticle;
    private Transform spawnPos;
    private ContactPoint2D hitPoint;

    void Start()
    {
        spawnPos = transform;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        hitPoint = col.GetContact(0);

        Instantiate(hitParticle, hitPoint.point, spawnPos.rotation);
    }
}
