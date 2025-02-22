using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForCameraLevel3 : MonoBehaviour
{
    public CameraFollover cameraFollover;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            cameraFollover.SwitchToFollowY();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            cameraFollover.SwitchToFollowX();
        }
    }
}
