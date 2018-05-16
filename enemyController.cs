using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour {
	NavMeshAgent nav;
	public Transform target;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (target.position);
	}
	void OnCollisionEnter (Collision arg) {
		if (arg.gameObject.tag == "bullet") {
			Destroy (gameObject);
			Destroy (arg.gameObject);
		}
		if (arg.gameObject.tag == "player") {
			Destroy (arg.gameObject);
		}
	}
}
