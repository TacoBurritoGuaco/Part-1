using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        //transform.Translate(speed * Time.deltaTime, 0, 0);
        //Old week-1 code
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
