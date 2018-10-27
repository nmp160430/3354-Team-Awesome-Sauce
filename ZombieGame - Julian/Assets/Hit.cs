using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }






    void ApplyDamage(float damage)
    {
        //Debug.Log("I was hit by a Ray");
        print(damage);
    }

    void HitByRay()
    {
        print("I was hit by Ray");
    }



}

