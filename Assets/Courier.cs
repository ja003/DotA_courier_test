using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Courier : MonoBehaviour
{

	[SerializeField] private float speed = 1;
	[SerializeField] private float rotationSpeed = 1;
	private Animator a;
	public Courier otherCourier;


	// Use this for initialization
	void Start ()
	{
		a = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += -transform.forward * speed;
			a.SetBool("walk", true);
		}
		else
		{
			a.SetBool("walk", false);
		}

		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.up, -rotationSpeed);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up, rotationSpeed);
		}
	}

	public void SwapCourier()
	{
		enabled = false;
		otherCourier.enabled = true;
	}
}
