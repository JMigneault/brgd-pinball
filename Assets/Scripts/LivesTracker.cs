using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesTracker : MonoBehaviour
{

    public int lives;
    public GameObject pinballPrefab;
    private int remainingLives;

    public void loseLife() {
        if (lives-- == 0) {
            // TODO: you lose :(
            Debug.Log("YOU LOSE!");
        } else {
            Debug.Log("lives remaining" + lives);
            Object.Instantiate(pinballPrefab);
        }

    }
    
}
