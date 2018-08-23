using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
        {
            other.rigidbody.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
        }
    }
}
