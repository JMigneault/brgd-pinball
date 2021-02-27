using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesTracker : MonoBehaviour
{

    public int startingLives;
    private int remainingLives;

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
            }
        }
        return remainingLives;

    }
    
}
