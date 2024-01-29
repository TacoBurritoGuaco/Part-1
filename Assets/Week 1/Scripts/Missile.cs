using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    float speed = 12f;
    Rigidbody2D rigidbody;
    Vector2 direction = new Vector2(-10, 0); //temporary assignment vector change while I figure out how to have the cannons change the missile's direction as well as its rotation
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

    private void OnCollisionEnter2D(Collision2D collision) //This does not work if you type it by hand
    {
        Debug.Log("Missile Hit Something");
        Destroy(gameObject); //this deletes the game object
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Missile triggered Something");
    }
}
