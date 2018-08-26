using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanMove : CharMove {
public Rigidbody2D chRB;
public bool stun = false;
public bool Chanstun = false;
public bool Chanstun3 = false;
    void Start()
    {        
        chRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(stun == false&&Chanstun == false&&Chanstun3 == false)
        {
            if(gameObject.tag == "Player1")
            base.Move();
            if(gameObject.tag == "Player2")
            base.Move2();
        }
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(this.tag == "Player1")
        {
            if(other.gameObject.tag == "P2Git1")
            {          
                chRB.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P2Git2"||other.gameObject.tag == "P2Git3")
            {               
                StartCoroutine("isStun");                             
            }
            if(other.gameObject.tag == "P2Chan1")
            {
                StartCoroutine("isChanStun");
            }
            if(other.gameObject.tag == "P2Chan3")
            {
                StartCoroutine("isChanskill3Stun");
            }
        }
        else
        {
            if(other.gameObject.tag == "P1Git1")
            {          
                chRB.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P1Git2"|| other.gameObject.tag == "P1Git3")
            {                
                StartCoroutine("isStun");                             
            }
            if(other.gameObject.tag == "P1Chan1")
            {
                StartCoroutine("isChanStun");
            }
            if(other.gameObject.tag == "P1Chan3")
            {
                StartCoroutine("isChanskill3Stun");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
    IEnumerator isStun()
    {
        stun = true;
        yield return new WaitForSeconds(0.5f);
        stun = false;
    }
    IEnumerator isChanStun()
    {
        Chanstun = true;
        yield return new WaitForSeconds(1f);
        Chanstun = false;
    }
    IEnumerator isChanskill3Stun()
    {
        Chanstun3 = true;
        yield return new WaitForSeconds(1.5f);
        Chanstun3 = false;
    }
}