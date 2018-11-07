using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBuild : MonoBehaviour
{
    public Transform brick;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
            
            // For creating cubes
            Instantiate(brick, hit.point, Quaternion.identity);

        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 1000, Color.green);
            
        }


    }
}
