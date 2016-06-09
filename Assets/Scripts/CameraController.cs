using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private GameObject player;
	private Vector3 pauDeSelfie;

	public float movementSmoothness = .5f;
	public float rotationSmoothness = .5f;

	void Start () {
		player = GameObject.FindWithTag ( "Player" );
		pauDeSelfie = transform.position - player.transform.position;

	}

	void FixedUpdate () {
		Vector3 targetPosition = player.transform.position + pauDeSelfie;
		transform.position = Vector3.Lerp ( transform.position, targetPosition, movementSmoothness );

		//Quaternion targetRotation = Quaternion.LookRotation ( player.transform.position - transform.position, Vector3.up );
		//transform.rotation = Quaternion.Lerp ( transform.rotation, targetRotation, rotationSmoothness );
	}
}