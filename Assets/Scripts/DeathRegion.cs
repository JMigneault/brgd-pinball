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
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collider.gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0f;
            collider.GetComponent<Pinball>().Reset();
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collider.gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0f;
        }


    }

}
