using UnityEngine;
using System.Collections;

public class GravityToggleController : MonoBehaviour {

	void OnTriggerEnter ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			Physics.gravity = - Physics.gravity;
		}
	}
}
