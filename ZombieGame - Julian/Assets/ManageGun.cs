using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGun : MonoBehaviour
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
            //Debug.Log("Did Hit");


            // For creating cubes
            //Instantiate(brick, new Vector3(1, 1, 1), Quaternion.identity);



            // Send message to aplly damage on gun hit
            //hit.transform.SendMessage("ApplyDamage", 10);

            // On hit deactivate
            hit.collider.gameObject.SetActive(false);
            
        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 1000, Color.green);
            //Debug.Log("Did not Hit");
        }


    }
}
