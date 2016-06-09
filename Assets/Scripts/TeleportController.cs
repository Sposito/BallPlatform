using UnityEngine;
using System.Collections;

public class TeleportController : MonoBehaviour {

	public GameObject targetPoint;
	public static bool canTeleport = true;

	void OnTriggerEnter ( Collider col ) {
		if ( col.CompareTag ( "Player" ) && canTeleport ) {
			col.transform.position = targetPoint.transform.position;
			canTeleport = false;
		}
	}

	void OnTriggerExit ( Collider col ) {
		if ( col.CompareTag ("Player") ) {
			canTeleport = true;
		}
	}
}
