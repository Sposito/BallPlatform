using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MovingPlatform {

	public GameObject loot;
	public float dropRate = .7f;
	public float playerBounceForce = 15;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		WayPointRoutine ();
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag("Player")){
			KillEnemy(col.GetComponent<Rigidbody>() );
			print ("col");
		}
	}

	void KillEnemy(Rigidbody rb){
		float rnd = Random.value;
		print (rnd);
		if ( rnd < dropRate) {
			Instantiate (loot, transform.position + Vector3.up, Quaternion.identity);
		}
		rb.AddForce (Vector3.up * playerBounceForce * 10000);
		Destroy (gameObject);
	}
}
