using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public AudioSource tickSource;
    public GameObject platform;
    public GameObject platformOff;
    public GameObject switchOn;
    public GameObject switchOff;

    public bool isOn = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;

        tickSource.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;

        isOn = true;
        platform.SetActive(false);
        tickSource.Play();
    }
}
