using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        audioSource.Play();
    }
}