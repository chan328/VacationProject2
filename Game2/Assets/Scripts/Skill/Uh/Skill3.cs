using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(this.tag == "P1Uh3")
        {
            while (Input.GetKeyDown(KeyCode.Space))
            {
                InvokeRepeating("PowerUp", 0, 0.2f);
            }
        }
        else if(this.tag == "P2Uh3")
        {
            while (Input.GetKeyDown(KeyCode.Keypad0))
            {
                InvokeRepeating("PowerUp", 0, 0.2f);
            }
        }
	}

    void PowerUp()
    {
        if (this.transform.localScale.x > 10 && this.transform.localScale.x < -10)
        {
            CancelInvoke("PowerUp");
        }
        if (this.transform.localScale.x < 0)
        {
            this.transform.localScale += new Vector3(-0.1f, -0.1f, 0);
        }
        else
        {
            this.transform.localScale += new Vector3(0.1f, 0.1f, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(this.tag == "P1Uh3")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (this.transform.localScale.x > 0)
                {
                    transform.Translate(0.1f, 0.1f, 0);
                }
                else
                {
                    transform.Translate(-0.1f, -0.1f, 0);
                }
            }
        }
       else if(this.tag == "P2Uh3")
        {
            if (Input.GetKeyUp(KeyCode.Keypad0))
            {
                if (this.transform.localScale.x > 0)
                {
                    transform.Translate(0.1f, 0.1f, 0);
                }
                else
                {
                    transform.Translate(-0.1f, -0.1f, 0);
                }
            }
        }
    }
}
