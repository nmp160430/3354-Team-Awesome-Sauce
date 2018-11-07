using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int health = 100;
    GameObject playerObj;


    float delay = 0.2f;
    float currentDelay = 0f;
    bool colorChange = false;

    private int DamageArtTimer = 0;

  
    public void Update()
    {
        //checkColorChange();
        
        if (DamageArtTimer > 0)
        {

            // Changes color of player when player is hit by zombie
            playerObj.GetComponent<Renderer>().material.color = Color.red;

            // If time elapsed is more than time elapsed + delay wanted, revert player back to original color
            if (Time.time > currentDelay)
            {
                playerObj.GetComponent<Renderer>().material.color = Color.white;
                colorChange = false;        // Set bool to false to not change color again unless hit
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.collider.name);
        if (col.gameObject.name == "Player")
        {

            Player player = col.gameObject.GetComponent<Player>();
            player.health--;
            print("Player health is: " + player.health);


            /*
            if (player.health <= 0)
            {
                col.gameObject.SetActive(false);

            }
            */

            playerObj = col.gameObject;
            //playerObj.GetComponent<Renderer>().material.color = Color.blue;

            
            colorChange = true;     // Player hit, set boolean to true to change color when update calls function
            currentDelay = Time.time + delay;    // Set delay to the time since game start + the delay we want (sec)

        }
    }

   

}