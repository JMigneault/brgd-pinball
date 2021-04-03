using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundTracker : MonoBehaviour
{

    public MoveBumper[] moveBumpers;
    public PointTracker pointTracker;
    public MoodDisplay moodDisplay;

    public int[] movesPerRound;

    private int currentRound = 0;

    void Start() {
        foreach (MoveBumper bumper in moveBumpers) {
            bumper.movesLeft = movesPerRound[currentRound];
        }
    }


    // called by LivesTracker
    public void NextRound() {
        // go to next round
        currentRound++;
        // display mood
        moodDisplay.ShowMood(pointTracker.GetPoints());
        // reset # of points
        pointTracker.ResetPoints();
        // set number of moves for the round
        if (currentRound > movesPerRound.Length) {
            Debug.LogErrorFormat("ERROR: number of moves allowed for round %i not specified.", currentRound);
        }
        foreach (MoveBumper bumper in moveBumpers) {
            bumper.movesLeft = movesPerRound[currentRound];
        }
    }

}
