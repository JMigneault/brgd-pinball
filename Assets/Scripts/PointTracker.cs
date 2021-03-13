using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracker : MonoBehaviour
{
    private int points;

    public void AddPoints(int newPoints) {
        this.points += newPoints;
        // Debug.Log("current points:" + points);
    }

    public int GetPoints() {
        return points;
    }

}

