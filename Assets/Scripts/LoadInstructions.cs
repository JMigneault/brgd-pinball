using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInstructions : MonoBehaviour
{

    public GameObject instructions;
    public GameObject cabinet;
    public GameObject left;
    public GameObject right;

    public void Show() {
        if (instructions.active) {
            instructions.SetActive(false);
            cabinet.SetActive(true);
            left.SetActive(true);
            right.SetActive(true);

        } else {
            instructions.SetActive(true);
            cabinet.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
        }
    }

}
