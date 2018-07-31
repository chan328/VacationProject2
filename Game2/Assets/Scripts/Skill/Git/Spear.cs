using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.Rotate(0, 0, -45);
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.GetComponentInParent<Transform>().localScale.x > 0)
        {
            transform.Translate(0.1f, 0.1f, 0);
        }
        else
        {
            transform.Translate(-0.1f, -0.1f, 0);
        }
        if (this.transform.position.x <= -4 || this.transform.position.x >= 4)
        {
            Destroy(gameObject);
        }
    }
}
