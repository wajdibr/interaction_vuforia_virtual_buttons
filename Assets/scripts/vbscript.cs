using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbscript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vButtonObject;
	private GameObject zombie;

	// Use this for initialization
	void Start () {
		vButtonObject = GameObject.Find ("actionbutton");
		zombie = GameObject.Find ("zombie");

		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("button pressed");
		zombie.GetComponent<Animation> ().Play ();
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("button released");
		zombie.GetComponent<Animation> ().Stop ();

	
	}


}
