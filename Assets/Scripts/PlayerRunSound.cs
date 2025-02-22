using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunSound : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip runClip; // Звуковой файл для бега
    private bool isRunning = false; // Флаг для отслеживания состояния бега

    void Update()
    {
        // Проверяем, нажата ли кнопка бега
        if (Input.GetButtonUp("Horizontal"))
        {
            StartRunning();
        }

        // Проверяем, отпущена ли кнопка бега
        if (Input.GetButtonDown("Horizontal"))
        {
            StopRunning();
        }
    }

    void FixedUpdate()
    {
        // Если бег активен, воспроизводим звук
        if (isRunning)
        {
            PlaySoundFromStart();
        }
    }

    void StartRunning()
    {
        if (!isRunning)
        {
            isRunning = true;
        }
    }

    void StopRunning()
    {
        isRunning = false;
    }

    void PlaySoundFromStart()
    {
        if (audioSource != null && runClip != null)
        {
            audioSource.PlayOneShot(runClip); // Воспроизведение звука с начала
        }
    }
}

