using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer : MonoBehaviour
 {
	 public GameObject disparo;
	 public Transform arma;


	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("Fire1"))
		{
			Instantiate(disparo, arma.position,arma.rotation);

		}
	}
}
