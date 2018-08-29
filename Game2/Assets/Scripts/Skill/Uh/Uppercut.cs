using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppercut : MonoBehaviour {
Rigidbody2D RB;
public GameObject Uh;
	// Use this for initialization
	void Start () {
		if(this.tag == "P1Uh1")
		Uh = GameObject.FindGameObjectWithTag("Player1");
		else if(this.tag == "P2Uh1")
		Uh = GameObject.FindGameObjectWithTag("Player2");
		Destroy(gameObject,0.3f);
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
	private void OnTriggerEnter2D(Collider2D other) {
		RB = other.GetComponent<Rigidbody2D>();
		RB.AddForce(new Vector2(0,5),ForceMode2D.Impulse);
	}
}
