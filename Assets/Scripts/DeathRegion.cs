using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRegion : MonoBehaviour
{

    public LivesTracker tracker;
    public MoodDisplay mood;

    void OnTriggerEnter2D(Collider2D collider) {
        // maintain points
        // delete ball here
        // call LoseLife in LivesTracker
            // what ball # is this?
            // if its the last ball -> end the game
            // recreayte the ball
        int remainingLives = tracker.LoseLife();
        mood.ShowMood();
        if (remainingLives > 0) {
            collider.GetComponent<Pinball>().Reset();
        }
    }

}
