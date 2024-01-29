using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerButton : MonoBehaviour //this is a revised version of the "lever" code from week 2 with more functionality
{
    // Start is called before the first frame update
    public GameObject trigger;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Ok so I've been stuck on this specific thing for 2 hours now so I'll explain my issue
        //I have NO clue how to make the spawn NOT turn off the canon sprite BUT I've come up with a solution
        //I'll just have the "Sprite" of the cannon be a wall, and the cannon itself be invisible
        //That was the cannon doesn't disapear, but the actual function does
        if (trigger == GameObject.Find("ObjectCannon")) //if the object is a Cannon
        {
            trigger.SetActive(!trigger.activeInHierarchy); //deactivate this Cannon
        }
        if (trigger == GameObject.Find("Door")) //if the object that is triggered is a door
        {
            trigger.SetActive(!trigger.activeInHierarchy); //deactivate this door
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger.SetActive(true); //turns the trigger that was previously deactivated back o
    }
}
