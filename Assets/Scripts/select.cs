using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour {

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown(){
		// this object was clicked - do something
		Destroy (this.gameObject);
	}   
}