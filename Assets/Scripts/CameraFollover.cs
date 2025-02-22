using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollover : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ персонажа
    public float smoothSpeed = 0.125f; // Плавность движения камеры
    public Vector3 offset; // Смещение камеры относительно персонажа

    private bool followX = true; // Флаг для слежения по оси X
    private bool followY = false; // Флаг для слежения по оси Y

    void LateUpdate()
    {
        Vector3 desiredPosition;

        if (followX)
        {
            // Следим только по оси X
            desiredPosition = new Vector3(player.position.x + offset.x, transform.position.y, offset.z);
        }
        else if (followY)
        {
            // Следим только по оси Y
            desiredPosition = new Vector3(transform.position.x, player.position.y + offset.y, offset.z);
        }
        else
        {
            // Не следим ни по одной из осей (оставляем камеру на месте)
            desiredPosition = transform.position;
        }

        // Плавное перемещение камеры
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    // Метод для изменения поведения камеры
    public void SwitchToFollowY()
    {
        followX = false;
        followY = true;
    }

        public void SwitchToFollowX()
    {
        followX = true;
        followY = false;
    }
}
