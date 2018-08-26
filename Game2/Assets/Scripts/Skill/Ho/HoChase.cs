using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoChase : MonoBehaviour {
	public GameObject Ho;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Ho0")
		Ho = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Ho0")
		Ho = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 0)
		{	
			this.transform.position = Ho.transform.position + new Vector3(0.8f, 0, -1);
		}		
		else
		{
			this.transform.position = Ho.transform.position + new Vector3(-0.8f, 0, -1);
		}
	}
}
