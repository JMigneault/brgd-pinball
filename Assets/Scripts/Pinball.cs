using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{

    AudioSource audioSource;
    Vector2 startingPosition;
    Rigidbody2D rbd;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = this.transform.position;
        rbd = this.GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Reset() {
        Debug.Log("Called into Pinball");
        // positon = startingPosition;
        this.transform.position = startingPosition;
        rbd.velocity = new Vector3(0, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag != "Bumper" && col.transform.tag != "Launcher")
        {
            audioSource.Play();
        }
    }
}
