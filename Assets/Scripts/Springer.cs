using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Springer : MonoBehaviour
{

    public float launchForce;
    public float downTime, pressTime = 0;

    public GameObject pinball;
    private Rigidbody2D pinballBody;
    private bool triggered = false;



    // Start is called before the first frame update
    void Start()
    {
        pinballBody = pinball.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if (Input.GetKeyDown("w"))
            {
                downTime = Time.time;
                StartCoroutine(MoveDown());
            }

            if (Input.GetKeyUp("w"))
            {
                StopCoroutine(MoveDown());
                pressTime = Time.time - downTime;
                pinballBody.AddForce(Vector3.up * launchForce * pressTime * 0.3f, ForceMode2D.Impulse);
                transform.localPosition = new Vector3(2.5f, -4.475f, 1f);
                transform.localScale = new Vector3(0.8f, 1f, 1f);
                triggered = false;
            }
        } 
       
    }


    void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.gameObject.tag == "Pinball" && Input.GetKey("w")) {
            pinballBody.AddForce(Vector3.up * launchForce, ForceMode2D.Impulse);
        }
    }

    void OnTriggerExit2D(Collider2D collidedObject)
    {
        triggered = false;
    }


    IEnumerator MoveDown()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.2f, transform.localPosition.z);
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - 0.2f, transform.localScale.z);
        yield return new WaitForSeconds(0.2f);
    }

}
