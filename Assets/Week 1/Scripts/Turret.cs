using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Vertical"); //Takes the up or down keys as a value when they are pressed
        transform.Rotate(0, 0, direction * speed * Time.deltaTime);
    }
}
