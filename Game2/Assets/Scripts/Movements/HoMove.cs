using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoMove : CharMove {
public Rigidbody2D RB;
public static int HP_2{get; set;}
int a;
public bool stun;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        if(transform.position.x == -1.5f)
        a = 1;
        if(transform.position.x == 2f)
        a = 2;
        HP_2 = 150; 
        Gameplayer.player2 =1;   
    }

    void FixedUpdate()
    {
        if(stun == false)
        {
            if(a==1)
            {
                base.Move();
            }      
            if(a==2)
            {
                base.Move2();
            }
        }               
        if(transform.position.y<-10)
        {
            HP_2 -= 20;
            transform.position = new Vector3(0,0,0);
        }
    }

    void Update()
    {
        if(HP_2<=0)
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(this.tag == "Player1")
        {
            if(other.gameObject.tag == "P2Git1")
            {          
                RB.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P2Git2"||other.gameObject.tag == "P2Git3")
            {               
                StartCoroutine("isStun");                             
            }
        }
        else
        {
            if(other.gameObject.tag == "P1Git1")
            {          
                RB.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P1Git2"|| other.gameObject.tag == "P1Git3")
            {                
                StartCoroutine("isStun");                             
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
}