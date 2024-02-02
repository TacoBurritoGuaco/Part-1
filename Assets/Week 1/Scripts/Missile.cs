using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Missile : MonoBehaviour
{
    float speed = 12f;
    Rigidbody2D rigidbody;
    Vector2 direction = new Vector2(-10, 0); //Direction changed to match to rotation of the sprite and the direction the missile is shot at for assignment 1
    // Start is called before the first frame update

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); //Might look familiar from processing!
        //Its akin to getting a pvector from an arraylist of objects.
        //In this case, its grabbing the RigidBody2D from the missile and saves it to rigidbody!
        //Saves a lot of time!

    }

    // Update is called once per frame
    void Update()
    {
        //finnaly found a way to fix the missile problem!
        //By simply having every missile check if the game over screen is active, I can have them each individually be destroyed
        if (!GameObject.Find("GameOverScreen").IsUnityNull()) //checks if the object is null, in which case, it does not continue with the rest of the if statement
            //This method is really handy to avoid errors! I'll make sure to keep it in mind as I go forwards with the course
        {
            if (GameObject.Find("GameOverScreen").activeInHierarchy) //detects if the game over screen is currently active and if it is not null
            {
                Destroy(gameObject); //if it is, the missile is destroyed
            }
        }
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }

    //Important note: "collision" in the case of this function is the object that this object is colliding with
    //Learnt this from Logan, 2nd year. 
    //This should allow me to then identify what this object is and as such have different things happen as a result
    private void OnCollisionEnter2D(Collision2D collision) //This does not work if you type it by hand
    {
        //Debug.Log("Missile Hit Something");
        Destroy(gameObject); //this deletes the game object
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Missile triggered Something");
    }
}
