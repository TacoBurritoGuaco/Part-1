using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentPlayer : MonoBehaviour
{
    Vector2 direction; //The direction that the player moves in (as a vector)
    public Rigidbody2D rigidbody; //The rigidbody
    public float force = 150; //set this to at least 100 or it won't make a difference
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //hm, ok, so this kind of changes my plans slightly
        //The code we used during last week's class already accounts for diagonal movement
        //I feel like I might be understimating how much easier everything is in unity.
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime); //this adds force in the direction that the player is holding
    }
}
