using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosAleatoriosSpawner: MonoBehaviour {

	public GameObject gema;
	public GameObject[] gemasList;

	
	public void Update () 
	{
		gemasList = GameObject.FindGameObjectsWithTag("Gema");
		if(gemasList.Length == 0) GemaSpawn();
		Debug.Log(gemasList.Length);
	}

	 public void GemaSpawn ()
	{
		for(int i = 0; i < 5; i++)
		{
			Vector3 randomSpawn = new Vector3(Random.Range(-10f,-10),Random.Range(-8f,8f),0);
			Instantiate(gema, randomSpawn,transform.rotation);
		}
	}
}
