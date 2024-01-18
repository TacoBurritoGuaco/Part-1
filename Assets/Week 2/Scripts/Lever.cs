using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject door;
    void Start()
    {
        door = GameObject.Find("Door"); //This is how you reference game objects without having to make them public
        //Don't call it in update!
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        door.SetActive(!door.activeInHierarchy);
    }
}
