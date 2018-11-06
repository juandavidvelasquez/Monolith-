using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	
	void Start () 
	{
		GetComponent<Collider>().attachedRigidbody.AddForce(1, 0, 1);
	}
	
	
}
