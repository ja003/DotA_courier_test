using UnityEngine;

public class Courier : MonoBehaviour
{
	[SerializeField] private float speed = 1;
	[SerializeField] private float rotationSpeed = 1;
	
	[SerializeField] private Animator normal_a;
	[SerializeField] private Animator flying_a;

	[SerializeField]
	private GameObject normalCourier;
	[SerializeField]
	private GameObject flyingCourier;


	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += transform.forward * speed;
			normal_a.SetBool("walk", true);
			flying_a.SetBool("walk", true);
		}
		else
		{
			normal_a.SetBool("walk", false);
			flying_a.SetBool("walk", false);
		}

		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(transform.up, -rotationSpeed);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(transform.up, rotationSpeed);
		}
	}

	public void SwapCourier(DragMouseOrbit camera)
	{
		if (normalCourier.gameObject.activeSelf)
		{
			normalCourier.gameObject.SetActive(false);
			flyingCourier.gameObject.SetActive(true);
			camera.target = flyingCourier.transform;
		}
		else
		{
			normalCourier.gameObject.SetActive(true);
			flyingCourier.gameObject.SetActive(false);
			camera.target = normalCourier.transform;

		}
	}
}
