using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = transform.parent.position;
	}
}
