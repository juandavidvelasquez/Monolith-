using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderWrench : MonoBehaviour {

	public GameObject sonido;

	public GameObject particulas;
	
	//public GameObject llave;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"));
		{
			sonido.SetActive(true);
		}
		}
	
		
     void OnTriggerExit(Collider other)
	{
			if(other.gameObject.CompareTag("Player"));
			{
				Instantiate(particulas, transform.position,transform.rotation);
				Destroy(gameObject);
			}
		}


	}

		
	

