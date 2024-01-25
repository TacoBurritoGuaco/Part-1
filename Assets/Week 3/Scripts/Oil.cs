using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    float currentDrag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentDrag = collision.attachedRigidbody.angularDrag;
        collision.attachedRigidbody.angularDrag = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.attachedRigidbody.angularDrag = currentDrag;
    }
}
