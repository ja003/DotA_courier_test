using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private Courier activeCourier;
	[SerializeField]
	private Courier normalCourier;
	[SerializeField]
	private Courier flyingCourier;

	[SerializeField] private DragMouseOrbit camera;

	// Use this for initialization
	void Start ()
	{
		activeCourier = normalCourier;
		normalCourier.otherCourier = flyingCourier;
		flyingCourier.otherCourier = normalCourier;
		camera.target = activeCourier.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SwapCourier();
		}
	}

	private void SwapCourier()
	{
		activeCourier.SwapCourier();
		activeCourier = normalCourier.enabled ? normalCourier : flyingCourier;
		camera.target = activeCourier.transform;
	}
}
