using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundTracker : MonoBehaviour
{

    public MoveBumper[] moveBumpers;
    private PointTracker pointTracker;
    public MoodDisplay moodDisplay;

    public int[] movesPerRound;

    private int currentRound = 1;

    public MoveBumper leftFlipper;
    public MoveBumper rightFlipper;

    public AudioSource musicSourceInitial;
    public AudioSource musicSourceLoop;
    private float initialMusicLength = 14.4f;

    void Start() {
        pointTracker = GetComponent<PointTracker>();
        leftFlipper.setUses(currentRound);
        rightFlipper.setUses(currentRound);
        Invoke("PlayMusicLoop", initialMusicLength);
    }


    // called by LivesTracker
    public void NextRound() {
        // go to next round
        currentRound++;
        leftFlipper.setUses(currentRound);
        rightFlipper.setUses(currentRound);
        // reset # of points
        pointTracker.ResetPoints();
    }

    void PlayMusicLoop()
    {
        musicSourceLoop.Play();
    }

}
