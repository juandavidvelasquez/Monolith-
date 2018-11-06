using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;// esta libreria de unity se usa para la inteligencia artificial ,pathfinders y navmesh
// este script es de navmesh para simular el movimiento de los robots y que sigan un target

public class InteligenciaArtificial : MonoBehaviour
{
	[SerializeField] Transform target;
	[SerializeField] NavMeshAgent agent ;
	[SerializeField] float  UpdateDelay = .3f ;
	public Transform mirar;


	void reset ()
	{
		agent = GetComponent<NavMeshAgent> ();
	}

	void OnTriggerEnter (Collider other) 
{
		if (other.gameObject.tag == "Player") 
		{
			//mirar al personaje o objeto cada vez que cambie de posicion
			transform.LookAt (mirar);
			InvokeRepeating("FollowTarget",0f,UpdateDelay);
		}

}

void FollowTarget() 
	{
		agent.SetDestination(target.position);
     }
  }