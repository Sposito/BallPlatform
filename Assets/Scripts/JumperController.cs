using UnityEngine;
using System.Collections;

public class JumperController : MonoBehaviour {

	public float jumpForce = 500f;
	public Color activeColor;

	public float colorSpeed = 5f;

	private Color defaultColor;

	void Start () {
		defaultColor = GetComponent<Renderer>().material.color;
	}

	void Update () {
		Renderer myRenderer = GetComponent<Renderer> ();
		myRenderer.material.color = Color.Lerp ( myRenderer.material.color, defaultColor, colorSpeed * Time.deltaTime );
	}

	void OnTriggerEnter ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			col.GetComponent<Rigidbody> ().AddForce ( - Physics.gravity.normalized * jumpForce );
			GetComponent<Renderer>().material.color = activeColor;
		}
	}
}
