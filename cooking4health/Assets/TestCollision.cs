using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour {

	// void Ontrigger (Collision col)
    // {
    //     if(col.gameObject.name == "WaterBoundary")
    //     {
    //         Debug.Log("hello");
    //     }
    // }

	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "WaterBoundary")
        {
            Debug.Log("hello");
        }
	}
}
