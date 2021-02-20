using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBumper : MonoBehaviour
{

    public PointTracker tracker;
    public int pointValue;

    void OnCollisionEnter2D(Collision2D col) {
        if (col.transform.tag == "Pinball") {
            tracker.AddPoints(pointValue);
        }
    }

}
