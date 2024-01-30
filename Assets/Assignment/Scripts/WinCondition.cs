using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject gameOverScreen; //game over screen
    public GameObject winText; //win text for game over
    public GameObject loseText; //lose screen for game over
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOverScreen.SetActive(true); //turns on the gameOver screen
        winText.SetActive(true); //turns on the win text
        loseText.SetActive(false); //turns off the lose text
    }
}
