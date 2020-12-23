using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSound : MonoBehaviour
{
    AudioSource audioSource;
    public float minPitch = 0.1f;
    private float pitchFromCar;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch;
    }

    private void Update()
    {
        pitchFromCar = CarController.speedInput;
        if (pitchFromCar < minPitch)
        {
            audioSource.pitch = minPitch;
        }
        else
        {
            audioSource.pitch = 1 + (pitchFromCar / 1000f / 8f);
        }
    }
}
