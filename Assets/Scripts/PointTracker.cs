using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracker : MonoBehaviour
{
    public LivesTracker livesTracker;

    private int points;
    private int cumulativePoints = 0;

    public int bonusRoundThreshold;
    public bool isBonusRoundAwarded = false;

    public void ResetPoints() {
        
        points = 0;
    }

    public void AddPoints(int newPoints) {
        this.points += newPoints;
        this.cumulativePoints += newPoints;
        if (cumulativePoints >= bonusRoundThreshold && !isBonusRoundAwarded)
        {
            print("bonus round awarded!");
            isBonusRoundAwarded = true;
        }
    }

    public int GetPoints() {
        return points;
    }

    public int GetCumulativePoints() {
        return cumulativePoints;
    }

}

