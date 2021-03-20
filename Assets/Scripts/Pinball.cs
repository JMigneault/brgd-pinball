using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{

    Vector2 startingPosition;
    Rigidbody2D rbd;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = this.transform.position;
        rbd = this.GetComponent<Rigidbody2D>();
    }

    public void Reset() {
        Debug.Log("Called into Pinball");
        // position = startingPosition;
        this.transform.position = startingPosition;
        // velocity = 0;
        rbd.velocity = new Vector3(0, 0, 0);
    }

}
