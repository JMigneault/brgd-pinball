using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRegion : MonoBehaviour
{

    public LivesTracker tracker;
    public MoodDisplay mood;

    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Hit death region");
        int remainingLives = tracker.LoseLife();
        //mood.ShowMood();
        if (remainingLives > 0) {
            collider.GetComponent<Pinball>().Reset();
        }
    }

}
