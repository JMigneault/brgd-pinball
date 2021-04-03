using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodDisplay : MonoBehaviour
{
    public PointTracker tracker;
    public Text mood_text;
    public GameObject pet;

    public Sprite psyched;
    public Sprite meh;
    public Sprite bummed;
    public Sprite happy;

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
            pet.GetComponent<SpriteRenderer>().sprite = bummed;
        }
        else if (points < 10) {
            mood_text.text = "Mood: Meh";
            pet.GetComponent<SpriteRenderer>().sprite = meh;
        }
        else if (points< 15) {
            mood_text.text = "Mood: Happy";
            pet.GetComponent<SpriteRenderer>().sprite = happy;
        }
        else {
            mood_text.text = "Mood: Psyched";
            pet.GetComponent<SpriteRenderer>().sprite = psyched;
        }

        // display mood
        yield return new WaitForSeconds(3);
        mood_text.gameObject.SetActive(false);
    }
}
