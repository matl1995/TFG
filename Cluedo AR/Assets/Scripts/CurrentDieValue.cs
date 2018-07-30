using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentDieValue : MonoBehaviour
{

	public static CurrentDieValue obj;

	public LayerMask dieValueColliderLayer=-1;

	static public int currentValue = 1;

	private bool rollComplete = false;

	private Rigidbody rigid;

	void Start() {
		rigid = GetComponent<Rigidbody>();
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
			SceneManager.LoadScene(currentValue.ToString());
		}
		else if(!rigid.IsSleeping())
		{
			rollComplete=true;
		}
	}

	static public void SetRoll(bool complete)
	{
		obj.rollComplete=complete;
	}
}
