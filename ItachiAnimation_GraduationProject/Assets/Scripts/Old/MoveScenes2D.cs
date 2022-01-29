﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour
{
    [SerializeField] private string newLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
       SceneManager.LoadScene(newLevel);
       
    }
}
