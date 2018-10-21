// Help from https://answers.unity.com/questions/1422377/on-collision-deal-damage-each-few-seconds-and-does.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lettuce : MonoBehaviour {

	public Transform dirt;

	// Timer to track collision time
     float _timeColliding;
     // Time before damage is taken, 1 second default
     public float timeThreshold = 1f;

	 // player health I assume?
     public int _currentHealth = 100;

	// Use this for initialization
	// called when first colliding
     void OnCollisionEnter(Collision collision) {
         if (collision.gameObject.tag == "Enemy") {
             // Reset timer
             _timeColliding = 0f;
 
             Debug.Log("Enemy started colliding with player.");
 
             // Take damage on impact?
              PlayerDamage(5);
         }
     }

	 // called each frame the collider is colliding
     void OnCollisionStay(Collision collision) {
         if(collision.gameObject.tag == "Enemy") {
             // If the time is below the threshold, add the delta time
             if (_timeColliding < timeThreshold) {
                 _timeColliding += Time.deltaTime;
             } else {
                 // Time is over theshold, player takes damage
                  PlayerDamage(5);
                 // Reset timer
                 _timeColliding = 0f;
             }
         }        
     }

	 void PlayerDamage(int amount) {
         _currentHealth -= amount;
         Debug.Log(_currentHealth);
         if(_currentHealth <= 0f) {
            dirt.localScale = new Vector3(0.0f,0.0f,0.0f);
         }
     }
}
