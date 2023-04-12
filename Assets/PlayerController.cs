using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 2;
    private float score = 0;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        animator = player.GetComponent<Animator>();
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector3(0, 0, 0)
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = Input.GetAxisRaw("Vertical")
        };

        direction = Vector3.ClampMagnitude(direction, 1);

        transform.position += direction * (speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintScore();
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
      print("Coin Acquired");
    }

    private void PrintScore()
    {
        print("I have: " + score + " points");
    }

    /* 
     AddScore encapsulates the private score variable. We want to do
     this because we want to give other parts of the program a way to
     modify the score, but hide its implementation.
    */
    public void AddScore(int amountToAdd )  
    {
        score += amountToAdd;
    }
}
