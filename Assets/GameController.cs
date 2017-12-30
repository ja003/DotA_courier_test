using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	[SerializeField]
	private Courier activeCourier;

	[SerializeField] private DragMouseOrbit camera;

	// Use this for initialization
	void Start ()
	{
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
		activeCourier.SwapCourier(camera);
	}
}
