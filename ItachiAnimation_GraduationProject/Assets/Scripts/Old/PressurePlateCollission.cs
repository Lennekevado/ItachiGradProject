using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateCollission : MonoBehaviour
{
    public AudioSource magicSource;
    public GameObject Barrier;
    public GameObject switchOn;
    public GameObject switchOff;

    public bool isOn = false;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
        magicSource.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;

        isOn = true;
        Barrier.SetActive(false);
        magicSource.Play();
    }

    void OnTriggerExit2D(Collider2D col)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;

        isOn = false;
        Barrier.SetActive(true);
    }
   
}
