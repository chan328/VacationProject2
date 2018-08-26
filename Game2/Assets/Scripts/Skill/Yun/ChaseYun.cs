using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseYun : MonoBehaviour {
public GameObject Yun;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Yun0"||this.tag == "P1Yun1")
		Yun = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Yun0"||this.tag == "P2Yun1")
		Yun = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 0)
		{	
			if(transform.localScale.x == 2 || transform.localScale.x == -2)
			this.transform.position = Yun.transform.position + new Vector3(1f, 0, -1);
			else
			this.transform.position = Yun.transform.position + new Vector3(0.6f, 0, -1);
		}		
		else
		{
			if(transform.localScale.x == 2 || transform.localScale.x == -2)
			this.transform.position = Yun.transform.position + new Vector3(-1f, 0, -1);
			else
			this.transform.position = Yun.transform.position + new Vector3(-0.6f, 0, -1);
		}
	}
}
