using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() //changed from ontriggercollision to update. Buttons will be the ones using triggers, not cannons
    {
        Instantiate(missilePrefab, spawn.position, spawn.rotation);
    }
}
