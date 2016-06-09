using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour {

	Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void OnTriggerStay(Collider col){
		rb.AddForce (Vector3.up * 2000);
		if (col.transform.position.y > 150)
			SceneManager.LoadScene (NextScene(),LoadSceneMode.Single);
	}
	int NextScene () {
		int next = SceneManager.GetActiveScene ().buildIndex + 1;
		if (next >= SceneManager.sceneCount)
			next = 0;
		return next;
	}
}
