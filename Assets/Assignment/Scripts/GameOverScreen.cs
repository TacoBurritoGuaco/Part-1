using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    //doors to reset
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;

    //cannons to reset
    public GameObject Cannon1;
    public GameObject Cannon2;

    //Player to reset position of
    public GameObject Player;
    public GameObject button;
    void Start()
    {
        
    }

    void Update()
    {
        //Turn off doors
        door1.SetActive(false);
        door2.SetActive(false);
        door3.SetActive(false);
        //Turn off cannons
        Cannon1.SetActive(false);
        Cannon2.SetActive(false);
        //Turn off player
        Player.SetActive(false);
        //Turn Off the button
        button.SetActive(false);

        //Got this from week 1
        if (Input.GetKeyDown(KeyCode.Space)) //when the space key is pressed
        {
            //========RESET ACTIVE========//
            //reset doors
            door1.SetActive(false);
            door2.SetActive(true);
            door3.SetActive(true);
            
            //reset cannons
            Cannon1.SetActive(true);
            Cannon2.SetActive(false);

            //reset player
            Player.SetActive(true);

            //resets the button
            button.SetActive(false);
            //===========================//

            Player.GetComponent<Transform>().localPosition = new Vector3(8, 0, 0); //resets the position of the player back to the player's original position
            gameObject.SetActive(false); //Sets this object to false, fully resetting the game
        }
    }
}
