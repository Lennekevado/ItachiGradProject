using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningText : MonoBehaviour
{
    public GameObject UiObject;

    void Start()
    {
        UiObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }
}