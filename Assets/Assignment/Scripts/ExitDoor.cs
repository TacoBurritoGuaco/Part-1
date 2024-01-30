using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public GameObject door1; //the door that must be closed
    public GameObject door2; //the door that must be open
    public GameObject closed; //The game object that turns green if the door its tied to is closed
    public GameObject open; //The game object that turns green if the door its tied to is open
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //For the first light:
        if (door1.activeInHierarchy) //if the door is closed
        {
            closed.GetComponent<SpriteRenderer>().color = Color.green; //turn green
        }
        else //if the door is open
        {
            closed.GetComponent<SpriteRenderer>().color = Color.red; //turn red
        }

        //for the second light:
        if (!door2.activeInHierarchy) //if the door is open
        {
            open.GetComponent<SpriteRenderer>().color = Color.green; //turn green
        }
        else //if the door is closed
        {
            open.GetComponent<SpriteRenderer>().color = Color.red; //turn red
        }

        //If both the open and closed lights are green
        if ((open.GetComponent<SpriteRenderer>().color == Color.green) && (closed.GetComponent<SpriteRenderer>().color == Color.green))
        {
            gameObject.SetActive(!gameObject.activeInHierarchy); //turns off the exit door (opens it)
        } //this happens upon completing the condition and does not repeat. it also does not turn the gameobject back on otherwise (making it more fun)
    }
}
