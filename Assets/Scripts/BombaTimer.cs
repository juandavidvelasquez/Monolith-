using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaTimer : MonoBehaviour {

	public float tiempo = 5;// se establece un tiempo limite para el contador y cuando llegue a 0 se activa 

	public GameObject bomb;

	public GameObject prefab;

	
	void Update () 
	{
		tiempo -= Time.deltaTime;// tiempo es menor o igual a tiempo por deltatime
		if(tiempo <= 0)// se crea  una condicion si el tiempo es menor o igual a 0 llama a la funcion autodestruir 
		{
			AutoDestroy();

		}
	}

	void AutoDestroy()
	{
		if(bomb != null)// si la bomba es igual a nula se instancia otra en la misma posicion 
		{
			Instantiate(bomb,transform.position, transform.rotation);

		}
		Destroy(gameObject);

		Instantiate(prefab,transform.position,transform.rotation);
		

	}

	
	}