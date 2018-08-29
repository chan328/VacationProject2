using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : MonoBehaviour {
public GameObject Uh;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Uh0"||this.tag == "P1Uh1")
		Uh = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Uh0"||this.tag == "P2Uh1")
		Uh = GameObject.FindGameObjectWithTag("Player2");
		Destroy(gameObject,0.6f);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 0)
		{	
			this.transform.position = Uh.transform.position + new Vector3(0.5f, 0.18f, -1);
		}		
		else
		{
			this.transform.position = Uh.transform.position + new Vector3(-0.5f, 0.18f, -1);
		}
	}
}
