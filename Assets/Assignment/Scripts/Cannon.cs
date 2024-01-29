using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//This class takes the basis of the original launcher script and expands upon it for further customizable elements
public class Cannon : MonoBehaviour
{
    public GameObject missilePrefab; //Calls the missile prefab created in week 1
    public Transform spawn; //Where the missiles spawn
    public float spawnRate; //the rate at which the missiles spawn
    float frameCount = 0; //counts for how long the object has been instantiated
    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate() //changed from ontriggercollision to update. Buttons will be the ones using triggers, not cannons
    {
        frameCount += 1; //increases framecount by 1 every frame
        if (frameCount % spawnRate == 0) //checks if the frame count when divided by 180 = 0
            //This is a trick I used during the last semester and should hopefully work the same here
        {
            Instantiate(missilePrefab, spawn.position, spawn.rotation); //instantiates an instance of the missile prefab that aligns with the spawn's rotation and position
        }
    }
}
