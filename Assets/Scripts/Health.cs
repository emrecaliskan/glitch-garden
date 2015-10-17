using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 100;
	
	public void DealDamage(float damage){
		health -= damage;
		if(health <=0){
			//Optionally trigger die animation
			DestroyObject();
		}
	}
	
	// Create seperate destroy object function to call as animator event.
	public void DestroyObject(){
		DestroyObject(gameObject);
	}
}
