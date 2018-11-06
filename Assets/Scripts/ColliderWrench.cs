using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderWrench : MonoBehaviour {

	public GameObject sonido;

	public GameObject particulas;
	
	//public GameObject llave;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == ("Player"))
		{
			sonido.SetActive(true);
		}
	
		else
		{
			if(other.gameObject.tag == ("Player"))
			{
				Instantiate(particulas, transform.position,transform.rotation);
				{
					//Destroy(other.gameObject);
				}
			}
		}
		

	}
		
	}

