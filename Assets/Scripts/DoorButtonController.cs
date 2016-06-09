using UnityEngine;
using System.Collections;

public class DoorButtonController : MonoBehaviour {

	private Vector3 activePosition;
	private Vector3 inactivePosition;
	private Vector3 targetPosition;

	public DoorController door;

	public bool isPressed = false;
	public float pressSpeed = 5f;

	// Use this for initialization
	void Start () {
		inactivePosition = transform.position;
		activePosition = transform.position + Vector3.down * GetComponent<Collider>().bounds.size.y;
		targetPosition = inactivePosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp ( transform.position, targetPosition, pressSpeed * Time.deltaTime );
	}

	void OnTriggerEnter ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			targetPosition = activePosition;
			door.isOpen = true;
		}
	}

	void OnTriggerExit ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			targetPosition = inactivePosition;
			door.isOpen = false;
		}
	}
}
