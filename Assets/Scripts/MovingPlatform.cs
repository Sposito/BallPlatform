using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform[] waypoints;
	public float moveSpeed = 3f;

	public int currentWaypointIndex = 0;

	void FixedUpdate () {
		WayPointRoutine ();
	}

	protected void WayPointRoutine(){
		transform.position = Vector3.MoveTowards ( transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.fixedDeltaTime );

		if ( Vector3.Distance ( transform.position, waypoints[currentWaypointIndex].position ) < .1f ) {
			currentWaypointIndex ++;
			if (  currentWaypointIndex > waypoints.Length - 1 ) {
				currentWaypointIndex = 0;	
			}
		}
	}
}
