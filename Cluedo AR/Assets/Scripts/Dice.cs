using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {

	public GameObject dice;

	public float Force=10.0f;

	public float Torque=10.0f;

	public ForceMode forceMode;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown()
	{
		dice.GetComponent<Rigidbody>().AddForce(transform.up*Force,forceMode);
		dice.GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere*Torque,forceMode);
	}
}
