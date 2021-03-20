using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBumper : MonoBehaviour
{

    HingeJoint2D joint;
    JointMotor2D motor;

    public float bumperSpeed;
    public int upDirection;
    public KeyCode key;

    public int movesLeft = 10;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
    }

    void Update() {

        if (Input.GetKeyDown(key) && movesLeft > 0) {
            movesLeft--;
            Debug.Log(movesLeft + " moves left on bumper: " + gameObject.name);
        }

        if (Input.GetKey(key) && movesLeft > 0) {
            ChangeMotorSpeed(bumperSpeed * upDirection, joint);
        } else {
            ChangeMotorSpeed(bumperSpeed * -upDirection, joint);
        }
    }

    static void ChangeMotorSpeed(float newSpeed, HingeJoint2D joint) {
        JointMotor2D motor = joint.motor;
        motor.motorSpeed = newSpeed;
        joint.motor = motor;
    }

}
