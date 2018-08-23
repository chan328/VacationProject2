using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	if(this.tag == "P1Yun0"||this.tag == "P2Yun0")
        Destroy(this.gameObject, 0.3f);
	else
	Destroy(this.gameObject, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
