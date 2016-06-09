using UnityEngine;
using System.Collections;

public class RisingActivator : MonoBehaviour {

	private RisingPlatform platform;

	void Start () {
		platform = GetComponentInChildren <RisingPlatform> ();
	}

	void OnTriggerEnter ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			platform.isReturning = true;
		}
	}

	void OnTriggerExit ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			platform.isReturning = false;
		}
	}
}
