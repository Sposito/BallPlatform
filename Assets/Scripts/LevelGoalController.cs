using UnityEngine;
using System.Collections;

public class LevelGoalController : MonoBehaviour {

	public bool isActive = false;
	private Rect guiRect = new Rect ( Screen.width / 2, Screen.height / 2, 300f, 300f );

	void OnGUI () {

		GUILayout.BeginArea ( guiRect );
		GUILayout.Label ( "Voce venceu!!!" );
		if ( GUILayout.Button ("Jogar Novamente") ) {

		}

		if ( GUILayout.Button ("Proxima Fase") ) {
			
		}
		GUILayout.EndArea ();

	}

	void OnTriggerEnter ( Collider col ) {
		if ( col.CompareTag ( "Player" ) ) {
			isActive = true;
		}
	}
}
