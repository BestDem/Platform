using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cameraPosition;
    private Vector3 offset; 

    private void Start()
    {
        offset = cameraPosition.transform.position - player.transform.position;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            Vector3 newCameraPosition = cameraPosition.transform.position;
            newCameraPosition.x = player.transform.position.x + offset.x;
            cameraPosition.transform.position = newCameraPosition;
        }
    }
}
