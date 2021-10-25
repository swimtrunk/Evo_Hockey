using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int playerOneScore = 0;
    public int playerTwoScore = 0;
    public int playerThreeScore = 0;
    public int playerFourScore = 0;

    public GameObject puckObjectWithScript;
    WhichContact whichContactScript;

    Text score;

    // Start is called before the first frame update
    void Start()
    {
        whichContactScript = puckObjectWithScript.GetComponent<WhichContact>();
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        score.text = playerOneScore.ToString() + "\n" + "\n" + playerTwoScore.ToString() + "\n" + "\n" + playerThreeScore.ToString() + "\n" + "\n" + playerFourScore.ToString();

    }
}
