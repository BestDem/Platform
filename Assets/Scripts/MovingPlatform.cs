using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    private SliderJoint2D movingPlatform;

    private void Start()
    {
        movingPlatform = platform.GetComponent<SliderJoint2D>();
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            JointMotor2D motor = movingPlatform.motor;
            motor.motorSpeed = -motor.motorSpeed;
            
            movingPlatform.motor = motor;
        }
    }
}
