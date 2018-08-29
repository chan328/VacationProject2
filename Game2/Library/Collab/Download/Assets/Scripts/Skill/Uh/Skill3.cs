using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill3 : MonoBehaviour {
    public static int a{get;set;}
    public Rigidbody2D rig;
    public CircleCollider2D Coll;
    public UhMove uhMove;
    public bool Using3;
	// Use this for initialization
	void Start () {
        a=0;
        Coll = this.gameObject.GetComponent<CircleCollider2D>();
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
        if(transform.parent.localScale.x>0)
        {
            transform.localScale = new Vector3(1, 1, -1);
        }
        else
        {
            transform.localScale = new Vector3(-1,-1,-1);
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
        if (transform.parent.localScale.x < 0)
        {
            this.transform.localScale += new Vector3(-0.1f, -0.1f, 0);
            Coll.radius += 0.000001f;
        }
        else if (transform.parent.localScale.x > 0)
        {
            this.transform.localScale += new Vector3(0.1f, 0.1f, 0);
            Coll.radius += 0.000001f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(a == 1)
        {
            Destroy(gameObject);
            uhMove.Using3 = false;
            a = 0;
        }       
        if(this.transform.position.x > 3 || this.transform.position.x < -3)
        {
            Destroy(this.gameObject);
        }
        if(this.tag == "P1Uh3")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                uhMove.Using3 = false;
                Transform parent = transform.parent;
                transform.parent = null;
                CancelInvoke("PowerUp");
                if (parent.localScale.x > 0)
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
                Transform parent = transform.parent;
                transform.parent = null;
                CancelInvoke("PowerUp");
                if (parent.localScale.x > 0)
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
