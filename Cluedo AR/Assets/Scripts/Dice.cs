using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour {

	public GameObject dice;

	public GameObject selector;

	public float Force=10.0f;

	public float Torque=10.0f;

	public ForceMode forceMode;

	public LayerMask dieValueColliderLayer=-1;

	static public int currentValue = 1;

	private bool rollComplete = false;

	private Rigidbody rigid;

	// Use this for initialization
	void Start () {
		rigid = dice.GetComponent<Rigidbody>();
		selector.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		if(Physics.Raycast(transform.position,Vector3.up,out hit,Mathf.Infinity,dieValueColliderLayer))
		{
			currentValue=hit.collider.GetComponent<DieValue>().value;
		}

		if(rigid.IsSleeping() && rollComplete)
		{
			rollComplete=false;
			selector.SetActive(true);
		}
	}

	void OnMouseDown()
	{
		dice.GetComponent<Rigidbody>().AddForce(transform.up*Force,forceMode);
		dice.GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere*Torque,forceMode);
		Collider c=GetComponent<Collider>();
		c.enabled=false;
		rollComplete=true;
	}
}
