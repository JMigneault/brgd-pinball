using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodDisplay : MonoBehaviour
{
    public PointTracker tracker;
    public Animator animator;
    public Text mood_text;
    public GameObject pet;

    public int mehThreshold;
    public int psychedThreshold;

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
        if (points < mehThreshold) {
            mood_text.text = "Mood: Bummed";
            animator.SetTrigger("roundEnd");
            animator.SetInteger("mood", 0);
            pet.GetComponent<SpriteRenderer>().sprite = bummed;
        }
        else if (points < psychedThreshold) {
            mood_text.text = "Mood: Meh";
            animator.SetTrigger("roundEnd");
            animator.SetInteger("mood", 1);
            pet.GetComponent<SpriteRenderer>().sprite = psyched;
        }
        else {
            mood_text.text = "Mood: Psyched";
            animator.SetTrigger("roundEnd");
            animator.SetInteger("mood", 2);
            pet.GetComponent<SpriteRenderer>().sprite = psyched;
        }

        // display mood
        yield return new WaitForSeconds(3);
        mood_text.gameObject.SetActive(false);
    }
}
