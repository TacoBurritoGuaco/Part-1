using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerButton : MonoBehaviour //this is a revised version of the "lever" code from week 2 with more functionality
{
    // Start is called before the first frame update
    public GameObject trigger; //The game object that the button turns on and off
    float delayTime = 60;
    bool hasTriggered = false;
    void Start()
    {

    }

    //This Fixedupdate is used specifically to add delay to when an object is turned back on or off to make the game a more enjoyable experience
    void FixedUpdate()
    {
        if (hasTriggered) //when an object has been turned on or off
        {
            delayTime -= 1; //decrease delayTime by 1 times Time.deltaTime
        }
        if (delayTime <= 0) //If delayTime is brought down to 0 or less
        {
            trigger.SetActive(true); //turns the trigger that was previously deactivated back on  
            delayTime = 60; //Resets delaytime
            hasTriggered = false; //resets hastriggered back to false
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger.SetActive(!trigger.activeInHierarchy); //deactivate the object added as a trigger
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        hasTriggered = true; //changes has triggered to true upon exiting the button
    }
}
