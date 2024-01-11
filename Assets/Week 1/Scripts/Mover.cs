using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal"); //Takes the left or right keys as a value when they are pressed
        transform.Translate(direction * speed * Time.deltaTime, 0, 0);
    }
}
