using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGun : MonoBehaviour
{
    public Transform brick;

    GameObject zombieObj;
    private GameObject LastZombieHit;

    int force = 5;

    
    
    // Update is called once per frame
    void Update()
    { 
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
            //Debug.Log("Did Hit");


            // Send message to aplly damage on gun hit
            //hit.transform.SendMessage("ApplyDamage", 10);

           
            Zombie zombie = hit.collider.gameObject.GetComponent<Zombie>();



            if (hit.collider.gameObject.GetComponent<Zombie>() != null)
            {
                if (zombie != null)
                {
                    if(LastZombieHit != null)
                    {
                        if (LastZombieHit != hit.collider.gameObject)
                        {
                            LastZombieHit.GetComponent<Renderer>().material.color = Color.white;
                        }

                        
                    }

                    LastZombieHit = zombie.gameObject;

                    // Do dmg to zombie with gun
                    zombie.health--;
                    print("Zombie health is: " + zombie.health);
                    

                    if (zombie.health <= 0)
                    {
                        // Both "remove" gameobj
                        //hit.collider.gameObject.SetActive(false);
                        //Destroy(hit.collider.gameObject);

                    }

                    // Makes object (zombie) move back
                    if (hit.rigidbody != null)
                    {
                        hit.rigidbody.AddForce(-hit.normal * force);
                        
                    }


                    zombieObj = hit.collider.gameObject;
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;

                }
            }

            // Added this if-else to reset color when you go from hitting zombie to hitting other object 
            else
            {
                zombieObj.GetComponent<Renderer>().material.color = Color.white;
            }
            

        }
       
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 1000, Color.green);
            //Debug.Log("Did not Hit");

            // When raycast doesn't hit, set zombie back to white
            zombieObj.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public static void fireGunArt(GameObject Gun)
    {

    }

    

 

}
