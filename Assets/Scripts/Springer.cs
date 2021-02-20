using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Springer : MonoBehaviour
{

    public float launchForce;

    public GameObject pinball;
    private Rigidbody2D pinballBody;

    

    // Start is called before the first frame update
    void Start()
    {
        pinballBody = pinball.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnTriggerStay2D(Collider2D collidedObject)
    {
        if (collidedObject.gameObject.tag == "Pinball" && Input.GetKey("w")) {
            pinballBody.AddForce(Vector3.up * launchForce, ForceMode2D.Impulse);
        }
    }

}
