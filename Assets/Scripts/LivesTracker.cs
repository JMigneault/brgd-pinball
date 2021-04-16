using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesTracker : MonoBehaviour
{

    public int startingLives;
    public int remainingLives;
    private bool isBonusRoundPlayed = false;
    public Health ballDisplay;

    private RoundTracker roundTracker;
    private PointTracker pointTracker;
    

    void Start() {
        pointTracker = GetComponent<PointTracker>();
        roundTracker = GetComponent<RoundTracker>();
        remainingLives = startingLives;
        Debug.Log("setting remaining lives in start");
    }

    public int LoseLife() {
        if (remainingLives > 0) {
            remainingLives--;
            if (remainingLives <= 0)
            {
                if(pointTracker.isBonusRoundAwarded && !isBonusRoundPlayed)
                {
                    print("bonus round!");
                    remainingLives = 1;
                    ballDisplay.hearts[0].enabled = false;
                    ballDisplay.hearts[0] = ballDisplay.hearts[ballDisplay.hearts.Length - 1];
                    isBonusRoundPlayed = true;
                    roundTracker.NextRound();
                }
                
                else
                {
                    // TODO: you lose :(
                    Debug.Log("YOU LOSE!");
                    // this is so that points for final round are added to cumulative count, lots of other ways we could do this
                    pointTracker.ResetPoints();
                    Debug.Log(pointTracker.GetCumulativePoints());
                }
            }
            else {
                Debug.Log("lives remaining: " + remainingLives);
                roundTracker.NextRound();
            }
        }
        return remainingLives;

    }

    public int GetLives() {
        return remainingLives;
    }

}
