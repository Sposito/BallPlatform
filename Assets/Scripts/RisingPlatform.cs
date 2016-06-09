using UnityEngine;
using System.Collections;

public class RisingPlatform : MonoBehaviour {

	private Vector3 targetPosition;
	private Quaternion targetRotation;

	private Vector3 lowerPosition;
	private Quaternion lowerRotation;

	public float moveSpeed = 5f;
	public bool isReturning = false;

	// Use this for initialization
	void Start () {
		targetPosition = transform.position;
		targetRotation = transform.rotation;

		transform.position -= Vector3.up * 15f;
		transform.Rotate ( transform.forward * Random.Range ( 10f, 90f ) );

		lowerPosition = transform.position;
		lowerRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (isReturning) {
			transform.position = Vector3.Lerp (transform.position, targetPosition, moveSpeed * Time.deltaTime);
			transform.rotation = Quaternion.Lerp (transform.rotation, targetRotation, moveSpeed * Time.deltaTime);
		} else {
			transform.position = Vector3.Lerp (transform.position, lowerPosition, moveSpeed * Time.deltaTime);
			transform.rotation = Quaternion.Lerp (transform.rotation, lowerRotation, moveSpeed * Time.deltaTime);
		}
	}
}
