using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodDisplay : MonoBehaviour
{
    public PointTracker tracker;
    public Text mood_text;

    // Start is called before the first frame update
    void Start()
    {
        mood_text = GetComponent<Text>();
        mood_text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ShowMood(int points) {
        // display mood
        mood_text.gameObject.SetActive(true);
        StartCoroutine(DisplayMessage(points));
    }

    IEnumerator DisplayMessage (int points) {
        // set mood
        if (points < 5) {
            mood_text.text = "Mood: Bummed";
        }
        else if (points < 10) {
            mood_text.text = "Mood: Meh";
        }
        else if (points< 15) {
            mood_text.text = "Mood: Happy";
        }
        else {
            mood_text.text = "Mood: Psyched";
        }

        // display mood
        yield return new WaitForSeconds(3);
        mood_text.gameObject.SetActive(false);
    }
}
