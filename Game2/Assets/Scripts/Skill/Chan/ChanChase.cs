using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanChase : MonoBehaviour {

	public GameObject Chan;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Chan0")
		Chan = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Chan0")
		Chan = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 0)
		{	
			this.transform.position = Chan.transform.position + new Vector3(0.5f, 0.18f, -1);
		}		
		else
		{
			this.transform.position = Chan.transform.position + new Vector3(-0.5f, 0.18f, -1);
		}
	}
}
