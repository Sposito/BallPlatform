using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	private Vector3 closedPosition;
	private Vector3 openedPosition;
	private Vector3 targetPosition;

	public bool isOpen = false;
	public float openSpeed = 7f;
	public float closeSpeed = .1f;

	public bool openUpwards = true;

	public float openDistance = 7f;

	// Use this for initialization
	void Start () {
		closedPosition = transform.position;
		openedPosition = (openUpwards) ? closedPosition + Vector3.up * openDistance : closedPosition - Vector3.up * openDistance;
		targetPosition = closedPosition;
	}
	
	// Update is called once per frame
	void Update () {
		float moveSpeed = (isOpen) ? openSpeed : closeSpeed;
		targetPosition = (isOpen) ? openedPosition : closedPosition;
		transform.position = Vector3.MoveTowards ( transform.position, targetPosition, moveSpeed * Time.deltaTime );
	}
}
