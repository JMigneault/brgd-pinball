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

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
    }

    void Update() {
        JointMotor2D motor = joint.motor;
        if (Input.GetKey(key)) {
            motor.motorSpeed = bumperSpeed * upDirection;
        } else {
            motor.motorSpeed = bumperSpeed * -upDirection;
        }
        joint.motor = motor;
    }

}
