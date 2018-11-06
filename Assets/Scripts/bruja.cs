using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bruja : MonoBehaviour 
{
	public Text texto;

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			texto.enabled = true;
		}
	}

	void OnTriggerExit(Collider other)
		{
			if (other.CompareTag("Player"))
		{
			texto.enabled = false;
		}
	}
}
