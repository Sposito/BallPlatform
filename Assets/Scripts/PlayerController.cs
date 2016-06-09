using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 50;
	public float jumpForce = 10f;
	public float moveAceleration = 3f;

	private float boostFactor = 1;

	public bool canJump = true;
	private bool canMove = true;

	public Color boostColor = Color.red;
	private Color baseColor;

	private bool init = false;

	private Rigidbody rb;
	Renderer rend;


	void Start () {
		rb = GetComponent <Rigidbody> ();
		rend = GetComponent<Renderer> ();
		baseColor = rend.materials [2].color;
	
	}

	void Update(){
		if (transform.position.y < -20f) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
		}
	}


	void FixedUpdate () {
		float h = Input.GetAxis ( "Horizontal" );
		float v = Input.GetAxis ( "Vertical" );
		//if (rb.velocity.sqrMagnitude <= maxSpeed) {
		if(init)
			rb.AddForce (new Vector3 (h, 0f, v) * moveAceleration * boostFactor);
		//}
		if ( Input.GetKeyDown ( KeyCode.Space ) && canJump ) {
			rb.AddForce ( - Physics.gravity.normalized * jumpForce * boostFactor );
			canJump = false;
			canMove = false;
		}
	}

	void OnCollisionEnter ( Collision col ) {
		if (!init)
			init = true;
		if (col.gameObject.CompareTag("Platform")){
			canJump = true;
		}
	}
		

	public void BoostSpeed(float duration, float factor){
		StartCoroutine (BoostCoroutine(duration,factor));
	}

	private IEnumerator BoostCoroutine(float duration, float factor){
		boostFactor *= factor;
		rend.materials [2].color = boostColor;
		yield return new WaitForSeconds (duration);
		boostFactor /= factor;
		rend.materials [2].color = baseColor;
	}
}
