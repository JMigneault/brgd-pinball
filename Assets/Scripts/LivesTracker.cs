using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesTracker : MonoBehaviour
{

    public int startingLives;
    private int remainingLives;

    public RoundTracker roundTracker;

    void Start() {
        remainingLives = startingLives;
        Debug.Log("setting remaining lives in start");
    }

    public int LoseLife() {
        if (remainingLives > 0) {
            remainingLives--;
            if (remainingLives == 0) {
                // TODO: you lose :(
                Debug.Log("YOU LOSE!");
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
