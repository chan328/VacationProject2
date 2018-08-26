using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanChase2 : MonoBehaviour {

	public GameObject Chan2;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Chan1")
		Chan2 = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Chan1")
		Chan2 = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 0)
		{	
			this.transform.position = Chan2.transform.position + new Vector3(0.5f, 0.18f, -1);
		}		
		else
		{
			this.transform.position = Chan2.transform.position + new Vector3(-0.5f, 0.18f, -1);
		}
	}
}
