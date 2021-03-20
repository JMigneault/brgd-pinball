using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracker : MonoBehaviour
{
    private int points;
    private int cumulativePoints = 0;

    public void ResetPoints() {
        cumulativePoints += points;
        points = 0;
    }

    public void AddPoints(int newPoints) {
        this.points += newPoints;
        Debug.Log("current points:" + points + gameObject.name);
    }

    public int GetPoints() {
        return points;
    }

    public int GetCumulativePoints() {
        return cumulativePoints;
    }

}

