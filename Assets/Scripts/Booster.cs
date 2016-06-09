using UnityEngine;
using System.Collections;

public class Booster : MonoBehaviour {
	public float duration = 5f;
	public float factor = 1.6f;
	PlayerController pController;
	void Start () {
		pController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}
	
	void OnTriggerEnter(Collider col){
		pController.BoostSpeed (duration, factor);
		Destroy (gameObject);
	}
}
