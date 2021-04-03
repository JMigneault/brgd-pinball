using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesTracker : MonoBehaviour
{

    public int startingLives;
    private int remainingLives;

    public RoundTracker roundTracker;
    private PointTracker pointTracker;

    void Start() {
        pointTracker = GetComponent<PointTracker>();
        remainingLives = startingLives;
        Debug.Log("setting remaining lives in start");
    }

    public int LoseLife() {
        if (remainingLives > 0) {
            remainingLives--;
            if (remainingLives == 0) {
                // TODO: you lose :(
                Debug.Log("YOU LOSE!");
                // this is so that points for final round are added to cumulative count, lots of other ways we could do this
                pointTracker.ResetPoints();
                Debug.Log(pointTracker.GetCumulativePoints());
            } else {
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
