using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill3 : MonoBehaviour {
    public Rigidbody2D rig;
    public UhMove uhMove;
    public bool Using3;
	// Use this for initialization
	void Start () {
        uhMove = transform.parent.GetComponent<UhMove>();
        rig = GetComponent<Rigidbody2D>();
        if(transform.parent.tag == "Player1")
        {
            this.tag = "P1Uh3";
        }
        else if(transform.parent.tag == "Player2")
        {
            this.tag = "P2Uh3";
        }
        InvokeRepeating("PowerUp", 0, 0.2f);
	}

    void PowerUp()
    {
        uhMove.Using3 = true;
        if (this.transform.localScale.x > 3 || this.transform.localScale.x < -3)
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
        if(this.transform.position.x > 3 || this.transform.position.x < -3)
        {
            Destroy(this.gameObject);
        }
        if(this.tag == "P1Uh3")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                uhMove.Using3 = false;
                transform.parent = null;
                CancelInvoke("PowerUp");
                if (this.transform.localScale.x > 0)
                {
                    rig.velocity = (new Vector2(2, 0));
                }
                else
                {
                    rig.velocity = (new Vector2(-2, 0));
                }
            }
        }
       else if(this.tag == "P2Uh3")
        {
            if (Input.GetKeyUp(KeyCode.Keypad0))
            {
                uhMove.Using3 = false;
                transform.parent = null;
                CancelInvoke("PowerUp");
                if (this.transform.localScale.x > 0)
                {
                    rig.velocity = (new Vector2(2, 0));
                }
                else
                {
                    rig.velocity = (new Vector2(-2, 0));
                }
            }
        }
    }
}
