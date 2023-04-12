using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip[] audioList;

    void Start()
    {
        var manager = GameObject.FindGameObjectWithTag("GameManager");
        audioSource = manager.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// Module 5 Exercise 1
// In order to prevent player1 from leaving the bounds of the camera, I put colliders at the edges of the screen.
