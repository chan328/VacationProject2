using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitChase : MonoBehaviour {
public GameObject Git;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Git0")
		Git = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Git0")
		Git = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 0)
		{	
			this.transform.position = Git.transform.position + new Vector3(0.5f, 0, -1);
		}		
		else
		{
			this.transform.position = Git.transform.position + new Vector3(-0.5f, 0, -1);
		}
	}
}

