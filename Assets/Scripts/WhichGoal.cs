using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichGoal : MonoBehaviour
{

    WhichContact whichContactScript;

    //Used to track Evos
    public int p1GoalHits = 0;
    public int p2GoalHits = 0;
    public int p3GoalHits = 0;
    public int p4GoalHits = 0;

    void Start()
    {
        whichContactScript = GetComponent<WhichContact>();
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Goal1")
        {
            p1GoalHits += 1;
        }
        else if(col.gameObject.tag == "Goal2")
        {
            p2GoalHits += 1;
        }
        else if(col.gameObject.tag == "Goal3")
        {
            p3GoalHits += 1;
        }
        else if(col.gameObject.tag == "Goal4")
        {
            p4GoalHits += 1;
        }
    }

}
