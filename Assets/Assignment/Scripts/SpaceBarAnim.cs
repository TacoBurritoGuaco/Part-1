using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpaceBarAnim : MonoBehaviour
{
    float speed = 0; //the speed at which the bar will move
    float timer = 0; //timer determining how long the bar will move in one direction
    bool change = false; //a boolean that determines when the bar should change direction

    // Update is called once per frame
    void FixedUpdate()
    {
        //Simple timer
        timer += 1; //increase timer by 1
        if (timer >= 60) //if you reach 60 (60 frames or 1 second)
        {
            timer = 0; //reset timer
            change = !change; //variable change switches to the opposite 
            //(true to false, false to true)
        }

        if (change) // if change is true
        {
            speed = 0.15f; //move upwards 
        }
        else //if it is false
        {
            speed = -0.15f; //move downwards 
        }
        transform.Translate(0, speed * Time.deltaTime, 0); //movement done using transform
        //same method as missile movement done in week 1 to demonstrate my knowledge of transform
    }
}
