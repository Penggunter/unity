using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	float h;
	float f;
	float mouseX;
	//float mouseY;
	public Rigidbody bullet;
	Rigidbody clone;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		//h = Input.GetAxis ("Horizontal");
		f = Input.GetAxis ("Fire1");
		mouseX = Input.GetAxis ("Mouse X");
		//mouseY = Input.GetAxis ("Mouse Y");
		//Vector3 force = new Vector3 (0, 0, v);
		rb.AddForce (tr.forward * v * 50f);
		Vector3 rotatoion = new Vector3 (0, mouseX, 0);
		tr.Rotate (rotatoion*5f);

		if (f > 0) {
			clone = Instantiate (bullet,tr.position,tr.rotation);
			clone.AddForce (tr.forward * 3000f);
		}
	}
}
