using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentPlayer : MonoBehaviour
{
    Vector2 direction; //The direction that the player moves in (as a vector)
    public Rigidbody2D rigidbody; //The rigidbody
    public float force = 150; //set this to at least 100 or it won't make a difference
    // Start is called before the first frame update

    //The gameover screen, the win screen, and the lose screen as objects used by the player
    public GameObject gameOverScreen;
    public GameObject winScreen;
    public GameObject loseScreen;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerFun")) //if the object called for collision is a missile
                                                          //This is found using object tags! They are very handy, and I'm glad I found it just by experimenting with object functions
                                                          //Will keep this in mind for the future.
        {
            gameOverScreen.SetActive(true); //turns on the gameoverscreen
            winScreen.SetActive(false); //turns off exit screen
            loseScreen.SetActive(true); //turns on the death screen
        }
    }
}
